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
    public partial class EditService : Form
    {
        public EditService()
        {
            InitializeComponent();
        }
        int value;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public EditService(int ServiceID) : this()
        {
            value = ServiceID;
            txtServiceID.Text = value.ToString();
        }

        public string baseAddress = "http://localhost:60004/api/";

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public Service GetByID(int ServiceID)
        {
            Service dichvu = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Service?ServiceID=" + ServiceID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Service>();
                    readTask.Wait();

                    dichvu = readTask.Result;
                }
                else
                {
                }
            }
            return dichvu;
        }
        public void PutDichVu(int ServiceID, string ServiceName, int UnitPrice, string Notes)
        {
            Service dv = new Service();
            dv.ServiceID = ServiceID;
            dv.ServiceName = ServiceName;
            dv.UnitPrice = UnitPrice;
            dv.Notes = Notes;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<Service>("Service", dv);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã sửa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa sửa được! ");
                }
            }
        }
        private void EditService_Load(object sender, EventArgs e)
        {
            Service dv = new Service();
            dv = GetByID(value);
            txtServiceID.Text = dv.ServiceID.ToString();
            txtServiceName.Text = dv.ServiceName.ToString();
            txtUnitPrice.Text = dv.UnitPrice.ToString();
            txtNotes.Text = dv.Notes.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ServiceID = Convert.ToInt32(txtServiceID.Text);
            string ServiceName = Convert.ToString(txtServiceName.Text);
            int UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
            string Notes = Convert.ToString(txtNotes.Text);
            PutDichVu(ServiceID, ServiceName, UnitPrice, Notes);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
