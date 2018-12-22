using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_iDental.Entities;

namespace WF_iDental
{
    public partial class MaterialReceipt : Form
    {
        public MaterialReceipt()
        {
            InitializeComponent();
        }//59809
        public string baseAddress = "http://localhost:59809/api/";
        int employeeID;
        string name;
        int materialid;
        public MaterialReceipt(int employee, string EmployeeName, int idvl) : this()
        {
            employeeID = employee;
            name = EmployeeName;
            materialid = idvl;
        }
        public List<MaterialReceipts> GetAll()
        {
            IEnumerable<MaterialReceipts> ds = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("MaterialReceipt");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MaterialReceipts>>();
                    readTask.Wait();

                    ds = readTask.Result;
                }
                else
                {
                    ds = Enumerable.Empty<MaterialReceipts>();

                }
            }
            return ds.ToList();
        }
        public void ThemNhapVatLieu(int MaterialID, DateTime ReceiptDate, int ReceiptAmount, int EmployeeID )
        {

            MaterialReceipts x = new MaterialReceipts();

            x.MaterialID = MaterialID;
            x.ReceiptDate = ReceiptDate;
            x.ReceiptAmount = ReceiptAmount;
            x.EmployeeID = EmployeeID;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<MaterialReceipts>("MaterialReceipt", x);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo  thêm được rồi ! ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa thêm được! ");
                }
            }

        }
        public MaterialShow GetByID(int id)
        {
            MaterialShow vt = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Material/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MaterialShow>();
                    readTask.Wait();

                    vt = readTask.Result;
                }
                else
                {
                }
            }
            return vt;
        } 
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MaterialReceipt_Load(object sender, EventArgs e)
        {
            txtmaterialid.Text = materialid.ToString();
            txtEmpolyeeID.Text = Convert.ToString(employeeID);
            txtEmployeeName.Text = name;
            txtMaterialName.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).MaterialName;
            txtProviderName.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).ProviderName;
            txtAmount.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).AvailableAmount.ToString();
            dataGridView1.DataSource = GetAll();

        }
        private void btnNhap_Click_1(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount2.Text);
            DateTime time = dateTimePicker1.Value;
            int employeeid = Convert.ToInt32(txtEmpolyeeID.Text);
            ThemNhapVatLieu(materialid , time , amount,employeeID);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
