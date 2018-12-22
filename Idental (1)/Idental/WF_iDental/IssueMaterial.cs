using Data_iDental.Entities;
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

namespace WF_iDental
{
    public partial class IssueMaterial : Form
    {
        public IssueMaterial()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:59809/api/";
        int employeeIssue;
        int materialid;
        string name;
        public IssueMaterial(int employeeID, int materialID, string employeename) : this()
        {
            employeeIssue = employeeID;
            materialid = materialID;
            name = employeename;

        }
        public List<MaterialIssues> GetAll()
        {
            IEnumerable<MaterialIssues> ds = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("MaterialIssue");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MaterialIssues>>();
                    readTask.Wait();

                    ds = readTask.Result;
                }
                else
                {
                    ds = Enumerable.Empty<MaterialIssues>();

                }
            }
            return ds.ToList();
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
        public void ThemXuatVatLieu(int MaterialID, DateTime IssueDate, int IssueAmount, int EmployeeID)
        {

            MaterialIssues x = new MaterialIssues();

            x.MaterialsID = MaterialID;
            x.IssueDate = IssueDate;
            x.IssueAmount = IssueAmount;
            x.EmployeeID = EmployeeID;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<MaterialIssues>("MaterialIssue", x);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo xuất được rồi ! ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa xuất được! ");
                }
            }

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueMaterial_Load(object sender, EventArgs e)
        {

            txtmaterialid.Text = materialid.ToString();
            txtemployeeID.Text = Convert.ToString(employeeIssue);
            txtemployeeName.Text = name;
            txtmaterialName.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).MaterialName;
            txtProviderName.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).ProviderName;
            txtAmount.Text = GetByID(Convert.ToInt32(txtmaterialid.Text)).AvailableAmount.ToString();
            dgvXuat.DataSource = GetAll();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtamount2.Text);
            DateTime time = dateTimePicker1.Value;
            int employeeid = Convert.ToInt32(txtemployeeID.Text);
            ThemXuatVatLieu(materialid, time, amount, employeeid);
            this.Close();
        }
    }
}
