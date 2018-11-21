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
        public void Block()
        {
            txtName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtImage.Enabled = false;
            cbbGender.Enabled = false;           
            dtpDateOfBirth.Enabled = false;
        }
        public void Reset()
        {
            txtName.Clear();
            txtName.Enabled = true;
            txtAddress.Clear();
            txtPhoneNumber.Enabled = true;
            txtPhoneNumber.Clear();
            txtAddress.Enabled = true;
            txtImage.Clear();
            txtImage.Enabled = true;
            cbbGender.SelectedItem = "";
            cbbGender.Enabled = true;
            dtpDateOfBirth.Value = DateTime.Now;
            dtpDateOfBirth.Enabled = true;
        }
      
        public void BindingData()
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvPatients.DataSource, "PatientName");
            txtPhoneNumber.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Add("Text", dgvPatients.DataSource, "PhoneNumber");
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", dgvPatients.DataSource, "Address");
            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("Text", dgvPatients.DataSource, "Image");
            cbbGender.DataBindings.Clear();
            cbbGender.DataBindings.Add("Text", dgvPatients.DataSource, "Gender");
            dtpDateOfBirth.DataBindings.Clear();
            dtpDateOfBirth.DataBindings.Add("Text", dgvPatients.DataSource, "DateOfBirth");
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
        public void PostPatient(string PatientName, DateTime DateOfBirth , string Gender , string PhoneNumber , string Address , string Image)
        {

            Patient bn = new Patient();

            bn.PatientName = PatientName;
            bn.DateOfBirth = DateOfBirth;
            bn.Gender = Gender;
            bn.PhoneNumber = PhoneNumber;
            bn.Address = Address;
            bn.Image = Image;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Patient>("Patient", bn);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo thêm được rồi ! ");
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa thêm được! ");
                }
            }

        }

        public void PutLichHen( int PatientID , string PatientName, DateTime DateOfBirth, string Gender, string PhoneNumber, string Address, string Image)
        {

            Patient bn = new Patient();
            bn.PatientID = PatientID;
            bn.PatientName = PatientName;
            bn.DateOfBirth = DateOfBirth;
            bn.Gender = Gender;
            bn.PhoneNumber = PhoneNumber;
            bn.Address = Address;
            bn.Image = Image;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP POST
                var postTask = client.PutAsJsonAsync<Patient>("Patient", bn);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo sửa được rồi ! ");
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa sửa được! ");
                }
            }

        }

        public void DeletePatient(int PatientID)
        {


            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);
                var responseTask = client.DeleteAsync($"Patient?PatientID=" + PatientID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo đã xóa được! ");
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa xóa được! ");
                }
            }
        }
        private void UC_Patient_Load(object sender, EventArgs e)
        {
            dgvPatients.DataSource = GetAll();
            txtPatientID.DataBindings.Clear();
            txtPatientID.DataBindings.Add("Text", dgvPatients.DataSource, "PatientID");

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
                            panelRecord.Width = 753;

                        }
                    else
                        if (panelRecord.BackColor == Color.White)//panelRecord.Width==640 &&
                        {
                            panelRecord.Width = 5;
                            panelRecord.BackColor = Color.MediumBlue;
                        }
                    //MessageBox.Show(dgvPatients.CurrentCell.Value.ToString());
                }                    

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void palLett_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelRecord.Width == 5 && panelRecord.BackColor == Color.MediumBlue)
            {
                panelRecord.BackColor = Color.White;
                panelRecord.Width = 753;

            }
            else
                       if (panelRecord.BackColor == Color.White)//panelRecord.Width==640 &&
            {   
                panelRecord.Width = 5;
                panelRecord.BackColor = Color.MediumBlue;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            txtName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtAddress.Enabled = true;
            txtImage.Enabled = true;
            cbbGender.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            BindingData();
        }

        private void cbbOptionts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbOptionts.SelectedItem.ToString()=="Thêm")
            {
                txtName.Clear();
                txtName.Enabled = true;
                txtAddress.Clear();
                txtPhoneNumber.Enabled = true;
                txtPhoneNumber.Clear();
                txtAddress.Enabled = true;
                txtImage.Clear();
                txtImage.Enabled = true;
                cbbGender.SelectedItem = "";
                cbbGender.Enabled = true;
                dtpDateOfBirth.Value = DateTime.Now;
                dtpDateOfBirth.Enabled = true;
            }else if (cbbOptionts.SelectedItem.ToString()=="Sửa")
            {
                txtName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtImage.Enabled = true;
                cbbGender.Enabled = true;
                dtpDateOfBirth.Enabled = true;
                BindingData();
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbOptionts.SelectedItem.ToString() == "Thêm")
            {
                string name = txtName.Text;
                DateTime dateofbirth = dtpDateOfBirth.Value;
                string gender = cbbGender.SelectedItem.ToString().Trim();
                string phone = txtPhoneNumber.Text;
                string address = txtAddress.Text;
                string image = txtImage.Text;
                PostPatient(name, dateofbirth, gender, phone, address, image);
                dgvPatients.DataSource = GetAll();
                Reset();

            }
            else if (cbbOptionts.SelectedItem.ToString() == "Sửa")
            {
                int PatientID = Convert.ToInt32(txtPatientID.Text);
                string name = txtName.Text;
                DateTime dateofbirth = dtpDateOfBirth.Value;
                string gender = cbbGender.SelectedItem.ToString().Trim();
                string phone = txtPhoneNumber.Text;
                string address = txtAddress.Text;
                string image = txtImage.Text;
                
                PutLichHen(PatientID, name, dateofbirth, gender, phone, address, image );
                dgvPatients.DataSource = GetAll();
                BindingData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xoa button
            BindingData();
            int PatientID = Convert.ToInt32(txtPatientID.Text);
            DeletePatient(PatientID);
            dgvPatients.DataSource = GetAll();
            BindingData();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
