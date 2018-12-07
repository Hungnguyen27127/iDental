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
    public partial class CompleteRecord : Form
    {
        public CompleteRecord()
        {
            InitializeComponent();
        }
        private string _message;
        public string baseAddress = "http://localhost:56664/api/";
        public string baseAddress1 = "http://localhost:60004/api/";
        public CompleteRecord(string Message) : this()
        {
            _message = Message;
            txtPatientID.Text = _message;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public void ThemChiTietDichVu(int ServiceID, int BillID)
        {

            ServiceDetail dv = new ServiceDetail();

            dv.ServiceID = ServiceID;
            dv.BillID = BillID;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ServiceDetail>("ServiceDetail", dv);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo thêm được rồi! ");
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa thêm được! ");
                }
            }

        }

        public void ThemDonThuoc(int medicineID, int medicalrecordID , string among , string usage)
        {

            MedicineDetail dt = new MedicineDetail ();

            dt.MedicalRecordID = medicalrecordID;
            dt.MedicineID = medicineID;
            dt.Usage = usage;
            dt.Among = among;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress1);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<MedicineDetail>("MedicineDetail", dt);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quang bảo thêm được rồi! ");
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa thêm được! ");
                }
            }

        }
        public List<Service> GetAll()
        {
            IEnumerable<Service> dichvu = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress1);
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
        public ShortenPatient InforPatient(int patientID)
        {
            ShortenPatient bn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Patient?patientID=" + patientID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ShortenPatient>();
                    readTask.Wait();
                    bn = readTask.Result;
                }
            }
            return bn;
        }

        public List<Medicine> GetCategory()
        {
            IEnumerable<Medicine> dichvu = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress1);
                //HTTP GET
                var responseTask = client.GetAsync("Medicine");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Medicine>>();
                    readTask.Wait();

                    dichvu = readTask.Result;
                }
                else
                {
                    dichvu = Enumerable.Empty<Medicine>();

                }
            }
            return dichvu.ToList();
        }

        public List<Medicine> SearchMedicineByName(string name)
        {
            IEnumerable<Medicine> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress1);
                //HTTP GET
                var responseTask = client.GetAsync("Medicine?CatelogyName=" + name);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Medicine>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<Medicine>();

                }
            }
            return lichhen.ToList();
        }

        public void PostRecord(int PatientID, DateTime DateOfCreate, string Diagnostic, int EmployeeID)
        {

            Record bn = new Record();

            bn.PatientID = PatientID;
            bn.DateOfCreate = DateOfCreate;
            bn.Diagnostic = Diagnostic;
            bn.PaymentState = "Chưa Thanh Toán";
            bn.EmployeeID = EmployeeID;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Record>("Records", bn);
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

        public void PutRecord(int MedicalRecordID, int PatientID, DateTime DateOfCreate, string Diagnostic, string PaymentState, int EmployeeID)
        {


            Record bn = new Record();
            bn.MedicalRecordID = MedicalRecordID;
            bn.PatientID = PatientID;
            bn.DateOfCreate = DateOfCreate;
            bn.Diagnostic = Diagnostic;
            bn.PaymentState = PaymentState;
            bn.EmployeeID = EmployeeID;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP POST
                var postTask = client.PutAsJsonAsync<Record>("Records", bn);
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

        public void DeleteRecord(int MedicalRecordID)
        {


            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);
                var responseTask = client.DeleteAsync($"Records?RecordID=" + MedicalRecordID);
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

        public List<BillExtend> GetBillExtend(int PAITENTID)
        {
            IEnumerable<BillExtend> bill = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Bill?patientID=" + PAITENTID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<BillExtend>>();
                    readTask.Wait();

                    bill = readTask.Result;
                }
                else
                {
                    bill = Enumerable.Empty<BillExtend>();

                }
            }
            return bill.ToList();
        }
        private void CompleteRecord_Load(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(txtPatientID.Text);
            labName.DataBindings.Add("Text", InforPatient(patientID), "PatientName", true);
            labDateOfBirth.DataBindings.Add("Text", InforPatient(patientID), "DateOfBirth", true);
            labGender.DataBindings.Add("Text", InforPatient(patientID), "Gender", true);
            cbbSeviceName.DataSource = GetAll();
            cbbSeviceName.DisplayMember = "ServiceName";
            cbbSeviceName.ValueMember = "ServiceID";
            txtDoctorID.Text = "5"; //  Sau khi Phân quyền sẽ lấy được DoctorID 
            txtservice.Text = "";
            txtservice.Hide();
            labChonDichVu.Visible = false;
            txtdiagnostic.Text = "";
            btnAddService.Visible = false;       
            dgvListBillExtend.Visible = false;
          

        }
   
        private void btnAddService_Click(object sender, EventArgs e)
        {         
            if (palServiceMedicine.Height == 10 && palExtendBill.Width == 10)
            {
                palExtendBill.Width = 783;
                palServiceMedicine.Height = 225;
                dgvListBillExtend.Visible = true;
                dgvListBillExtend.DataSource = GetBillExtend(Convert.ToInt32(txtPatientID.Text));
                txtBillID.DataBindings.Clear();
                txtBillID.DataBindings.Add("Text", dgvListBillExtend.DataSource,"BillID");
                txtRecordID.DataBindings.Clear();
                txtRecordID.DataBindings.Add("Text", dgvListBillExtend.DataSource, "MedicalRecordID");
                cbbCatelogy.DataSource = GetCategory();
                cbbCatelogy.DisplayMember = "Category";
                btnNext.Visible = false;
              
            }
            else
            {
                palServiceMedicine.Height = 10;
                palExtendBill.Width = 10;
                dgvListBillExtend.Hide();
            }
        }
       

        private void btnNext_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(txtPatientID.Text);
            string diagnostic = Convert.ToString(txtdiagnostic.Text);
            int employeeID = Convert.ToInt32(txtDoctorID.Text);
            DateTime dateofcreate = Convert.ToDateTime(dtkDateOfCreate.Value);

            if (txtdiagnostic.Text != "")
            {
                PostRecord(patientID, dateofcreate, diagnostic, employeeID);

                labChonDichVu.Visible = true;
                txtservice.Visible = true;
                btnAddService.Visible = true;
                btnNext.Visible = false;
            }
            else
            {
                MessageBox.Show(" Quang bảo không thêm được vì chưa điền chuẩn đoán ! ");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            palServiceMedicine.Height = 10;
            palExtendBill.Width = 10;
            dgvListBillExtend.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            int recordID = Convert.ToInt32(txtRecordID.Text);
            int medicineID = Convert.ToInt32(cbbMedicine.SelectedValue);
            string among = txtAmong.Text;
            string usage = txtUsage. Text ;
            int serviceid = Convert.ToInt32(cbbSeviceName.SelectedValue.ToString());
            int billid = Convert.ToInt32(txtBillID.Text);
            ThemChiTietDichVu(serviceid, billid);
            ThemDonThuoc(medicineID , recordID , among , usage);
            if (txtservice.Text == "")
            {
                txtservice.Text = cbbSeviceName.Text.ToString();
            }
            else
            {
                txtservice.Text += "," + cbbSeviceName.Text.ToString();
            }
            palServiceMedicine.Height = 10;
            palExtendBill.Width = 10;
            dgvListBillExtend.Hide();
            btnCancel.Text = "Xong";
           
        }

        private void cbbCatelogy_SelectedValueChanged_1(object sender, EventArgs e)
        {
            cbbMedicine.DataSource = SearchMedicineByName(cbbCatelogy.Text.Trim());
            cbbMedicine.DisplayMember = "MedicineName";
            cbbMedicine.ValueMember = "MedicineID";
          
        }

        private void cbbCatelogy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void palRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void palLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void palAddSevice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}