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
    //public delegate void SendMessage(string value);
    public partial class UC_Diagnostic : UserControl
    {
        public UC_Diagnostic()
        {
            InitializeComponent();
        }
    
    

        public string baseAddress = "http://localhost:56664/api/";

        private void dgvPatientforDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingData();
            if (e.RowIndex == -1) return; //check if row index is not selected
            if (dgvPatientforDoctor.CurrentCell.ColumnIndex.Equals(0))
                if (dgvPatientforDoctor.CurrentCell != null && dgvPatientforDoctor.CurrentCell.Value.ToString() != "")
                {
                  
                    CompleteRecord f = new CompleteRecord(txtPatientID.Text);
                    f.ShowDialog();
                }
        }
        public void BindingData()
        {
            txtPatientID.DataBindings.Clear();
            txtPatientID.DataBindings.Add("Text",dgvPatientforDoctor.DataSource,"PatientID");
        }

         public List<Patient> GetAllPatient()
         {
            IEnumerable<Patient> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Patient");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Patient>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<Patient>();

                }
            }
            return lichhen.ToList();
        }

        public List<Patient> SearchPatientByName(string name)
        {
            IEnumerable<Patient> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Patient?name="+name);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Patient>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<Patient>();

                }
            }
            return lichhen.ToList();
        }




        private void UC_Diagnostic_Load(object sender, EventArgs e)
        {
          //  int id = 4;            
            dgvPatientforDoctor.DataSource = GetAllPatient();           
            BindingData();
        }

        private void dgvPatientforDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
           dgvPatientforDoctor.DataSource= SearchPatientByName(txtSearch.Text.Trim());

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {          
            try
            {
                string name = txtSearch.Text;
                dgvPatientforDoctor.DataSource = SearchPatientByName(name);
            }
            catch (NullReferenceException ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                dgvPatientforDoctor.DataSource = SearchPatientByName(txtSearch.Text.Trim());


            }
        }
    }
}
