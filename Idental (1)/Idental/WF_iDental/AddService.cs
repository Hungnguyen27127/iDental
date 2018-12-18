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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }
        int value;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public AddService(int ServiceID) : this()
        {
            value = ServiceID;
            //txtAppointmentID.Text = value.ToString();
        }
        public string baseAddress = "http://localhost:60004/api/";
        // apipostnew

        public void ThemDichVu(string ServiceName, int UnitPrice, string Notes)
        {

            Service dv = new Service();

            dv.ServiceName = ServiceName;
            dv.UnitPrice = UnitPrice;
            dv.Notes = Notes;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Service>("Service", dv);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa thêm được dữ liệu! ");
                }
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            int UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
            string ServiceName = Convert.ToString(txtServiceName.Text);
            string Notes = Convert.ToString(txtNotes.Text);
            //int AppointmentID =Convert.ToInt32(txtAppointmentID.Text) ;
            ThemDichVu(ServiceName, UnitPrice, Notes);

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
