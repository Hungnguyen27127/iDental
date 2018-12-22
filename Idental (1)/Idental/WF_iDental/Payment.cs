using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_iDental
{
    public partial class Payment : Form
    {
        private string _message1;
        private string _message2;
        public Payment()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:56664/api/";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Payment(string Message1, string Message2): this()
        {
            _message1 = Message1;
            txtMedicalRecordID.Text = _message1;
            _message2 = Message2;
            txtName.Text = _message2;
        }

        private void btnBillCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
           
            int MedicalRecordID = Convert.ToInt32(txtMedicalRecordID.Text);
            PutPaymentState(MedicalRecordID);
           // dgvBill.DataSource = GetChiTietHoaDon(MedicalRecordID);
            this.Close();
        }


        private void palBillTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
   
        public void PutPaymentState(int MedicalRecordID)
        {

            Record lh = new Record();
            lh.MedicalRecordID = MedicalRecordID;
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<Record>("Bill",lh);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo sửa được rồi ! ");
                   // this.Close();

                }
                else
                {
                    MessageBox.Show("Quang bảo chưa sửa được ! ");
                }
            }

        }
        public List<Bill> GetChiTietHoaDon(int MedicalRecordID)
        {
            IEnumerable<Bill> ghd = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Bill?MedicalRecordID=" + MedicalRecordID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Bill>>();
                    readTask.Wait();

                    ghd = readTask.Result;
                }
                else
                {
                    ghd = Enumerable.Empty<Bill>();

                }
            }
            return ghd.ToList();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            int MedicalRecordID = Convert.ToInt32(txtMedicalRecordID.Text);
            dgvBill.DataSource = GetChiTietHoaDon(MedicalRecordID);
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtTotalBill_MouseClick(object sender, MouseEventArgs e)
        {
            int socot = dgvBill.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < socot ; i++)
            {
                thanhtien += float.Parse(dgvBill.Rows[i].Cells["UnitPrice"].Value.ToString());
            }
            txtTotalBill.Text = thanhtien.ToString();
        }
    }
}
