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
    public partial class UC_Patient : UserControl
    {
        public UC_Patient()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:56664/api/";
        private void Test_Click(object sender, EventArgs e)
        {
            if (panelRecord.Width == 5 && panelRecord.BackColor == Color.MediumBlue )
            {
                panelRecord.BackColor = Color.White;
                panelRecord.Width = 766;

            }else
                if( panelRecord.BackColor == Color.White)//panelRecord.Width==640 &&
            {
                panelRecord.Width = 5;
                panelRecord.BackColor = Color.MediumBlue;
            }
                
        }

       //api
        public List<Patient> GetAll()
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


        private void UC_Patient_Load(object sender, EventArgs e)
        {
            dgvPatients.DataSource = GetAll();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1) return; //check if row index is not selected
            if (dgvPatients.CurrentCell.ColumnIndex.Equals(0))
                if (dgvPatients.CurrentCell != null && dgvPatients.CurrentCell.Value.ToString() != "")
                    {
                    if (panelRecord.Width == 5 && panelRecord.BackColor == Color.MediumBlue)
                        {
                            panelRecord.BackColor = Color.White;
                            panelRecord.Width = 766;

                        }
                    else
                        if (panelRecord.BackColor == Color.White)//panelRecord.Width==640 &&
                        {
                            panelRecord.Width = 5;
                            panelRecord.BackColor = Color.MediumBlue;
                        }
                    MessageBox.Show(dgvPatients.CurrentCell.Value.ToString());
                }
                    
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
