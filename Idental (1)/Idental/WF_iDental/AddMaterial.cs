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
    public partial class AddMaterial : Form
    {
        public AddMaterial()    
        {
            InitializeComponent();
        }
        int value;
        public AddMaterial(int id) : this()
        {
            value = id;
            //txtAppointmentID.Text = value.ToString();
        }
        public string baseAddress = "http://localhost:59809/api/";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
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
        public void PostMaterial(string MaterialName, int ProviderID, int AvailableAmount, DateTime ExpirationDate)
        {

            Material vt = new Material();

            vt.MaterialName = MaterialName;
            vt.ProviderID = ProviderID;
            vt.AvailableAmount = AvailableAmount;
            vt.ExpirationDate = ExpirationDate;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Material>("Material", vt);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm mới thành công! ");
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại! ");
                }
            }

        }
        private void AddMaterial_Load(object sender, EventArgs e)
        {
            cbxProvider.DataSource = LoadDataProviderComboBox();
            cbxProvider.ValueMember = "ProviderID";
            cbxProvider.DisplayMember = "ProviderName";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int providerid = Convert.ToInt32(cbxProvider.SelectedValue);
            int amount = Convert.ToInt32(txtAmount.Text.Trim());
            DateTime date = dtpDate.Value;
            PostMaterial( name , providerid,amount , date);
            this.Close();
        }
    }
}
