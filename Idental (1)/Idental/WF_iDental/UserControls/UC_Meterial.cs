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
    public partial class UC_Meterial : UserControl
    {
        public UC_Meterial()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:59809/api/";
        int employeeID;
        string employeeName;
       
        public UC_Meterial(int employee ,string name ) : this()
        {
            employeeID = employee;
            employeeName = name;
            
        }
        public void BindingData()
        {
            txtMaterialID.DataBindings.Clear();
            txtMaterialID.DataBindings.Add("Text", dataGridView1.DataSource, "MaterialID");
        }
        public List<MaterialShow> GetAll()
        {
            IEnumerable<MaterialShow> vattu = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Material");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MaterialShow>>();
                    readTask.Wait();

                    vattu = readTask.Result;
                }
                else
                {
                    vattu = Enumerable.Empty<MaterialShow>();

                }
            }
            return vattu.ToList();
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

      
        public void DeleteMaterial(int MaterialID)
        {


            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);
                var responseTask = client.DeleteAsync($"Material?MaterialID=" + MaterialID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công! ");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! ");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtMaterialID.Text);
            MaterialReceipt f = new MaterialReceipt(employeeID , employeeName ,x);
            f.ShowDialog();
            dataGridView1.DataSource = GetAll();
            BindingData();
        }

        private void UC_Meterial_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAll();
            BindingData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaterialID.Text);
            AddMaterial f = new AddMaterial(id);
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaterialID.Text);
            EditMaterial f = new EditMaterial(id);
            f.ShowDialog();
            dataGridView1.DataSource = GetAll();
            BindingData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa vật tư này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                BindingData();
                int MaterialID = Convert.ToInt32(txtMaterialID.Text.Trim());
                DeleteMaterial(MaterialID);
                dataGridView1.DataSource = GetAll();
                BindingData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtMaterialID.Text);
            IssueMaterial f = new IssueMaterial(employeeID, x ,employeeName);
            f.ShowDialog();
            dataGridView1.DataSource = GetAll();
            BindingData();
        }
    }
}
