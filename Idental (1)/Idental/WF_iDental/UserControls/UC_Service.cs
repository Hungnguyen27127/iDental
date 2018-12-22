using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_iDental.Entities;
using System.Net.Http;

namespace WF_iDental.UserControls
{
    public partial class UC_Service : UserControl
    {
        public UC_Service()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:60004/api/";
        public void BindingData()
        {
            txtService.DataBindings.Clear();
            txtService.DataBindings.Add("Text", dgvDichVu.DataSource, "ServiceID");
        }
        public List<Service> GetAll()
        {
            IEnumerable<Service> dichvu = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Service");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Service>>();
                    readTask.Wait();
                    dichvu = readTask.Result;
                }
                else
                {
                    dichvu = Enumerable.Empty<Service>();
                }
            }
            return dichvu.ToList();
        }
        // gọi api
        private void UC_Service_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = GetAll();
            BindingData();
        }

      
        public void DeleteService(int ServiceID)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);
                var responseTask = client.DeleteAsync("Service?ServiceID=" + ServiceID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa thành công dữ liệu! ");
                }
                else
                {
                    MessageBox.Show("Chưa xóa được dữ liệu! ");
                }
            }
        }

     
        public List<Service> SearchServiceByName(string name)
        {
            IEnumerable<Service> sv = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Medicine?ServiceName=" + name);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Service>>();
                    readTask.Wait();

                    sv = readTask.Result;
                }
                else
                {
                    sv = Enumerable.Empty<Service>();

                }
            }
            return sv.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (dgvDichVu.RowCount > 1)
            {

                for (int i = 0; i <= dgvDichVu.RowCount; i++)
                {
                    Count++;
                }
            }

            using (AddService add = new AddService(Count))
            {
                add.ShowDialog();
            }
            dgvDichVu.DataSource = GetAll();
            BindingData();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // gọi api lấy dữ liệu theo mã 

            using (EditService edit = new EditService(Convert.ToInt32(txtService.Text)))
            {
                edit.ShowDialog();
            }
            dgvDichVu.DataSource = GetAll();
            BindingData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtService.Text);
            DeleteService(a);
            dgvDichVu.DataSource = GetAll();
            BindingData();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = SearchServiceByName(textBox1.Text.Trim());
        }
    }
}
