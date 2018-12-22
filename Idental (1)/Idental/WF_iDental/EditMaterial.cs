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
    public partial class EditMaterial : Form
    {
        public EditMaterial()
        {
            InitializeComponent();
        }
        int value;
        public EditMaterial(int id) : this()
        {
            value = id;
           textBox1.Text = value.ToString();
        }
        public string baseAddress = "http://localhost:59809/api/";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public List<Provider> LoadDataProviderComboBox()
        {
            List<Provider> ncc = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"Material?getProvider={true}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Provider>>();
                    readTask.Wait();

                    ncc = readTask.Result;

                }
            }
            return ncc;
        }
        public void PutVatTu(int MaterialID, string MaterialName, int ProviderID, int AvailableAmount, DateTime ExpirationDate)
        {

            Material vt = new Material();
            vt.MaterialID = MaterialID;
            vt.MaterialName = MaterialName;
            vt.ProviderID = ProviderID;
            vt.AvailableAmount = AvailableAmount;
            vt.ExpirationDate = ExpirationDate;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP POST
                var postTask = client.PutAsJsonAsync<Material>("Material", vt);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sửa thành công ! ");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại! ");
                }
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text.Trim());
            string name = txtName.Text.ToString().Trim();
            int providerid = Convert.ToInt32(cbxProvider.SelectedValue);
            int amount = Convert.ToInt32(txtAmount.Text.Trim());
            DateTime date = dtpDate.Value;
            PutVatTu(id, name, providerid, amount, date);
            this.Close();
        }

        private void EditMaterial_Load(object sender, EventArgs e)
        {
            cbxProvider.DataSource = LoadDataProviderComboBox();
            cbxProvider.ValueMember = "ProviderID";
            cbxProvider.DisplayMember = "ProviderName";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
