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
    public partial class EditAppointent : Form
    {
        public EditAppointent()
        {
            InitializeComponent();
        }
        int value;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public EditAppointent(int AppointmentID) : this()
        {
            value = AppointmentID;
            txtAppointmentID.Text = value.ToString();
        }

        public string baseAddress = "http://localhost:55965/api/";
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //api
        public Appointment GetByID(int AppointentID)
        {
            Appointment lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Appointment?AppointmentID="+ AppointentID);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Appointment>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa sửa được! ");

                }
            }
            return lichhen;
        }
        public void PutLichHen(int AppointmentID, int DoctorID, DateTime date,string phone,string name)
        {

            Appointment lh = new Appointment();
            lh.AppointmentID = AppointmentID;
            lh.EmployeeID = DoctorID;
            lh.Date = date;
            lh.PhoneNumber = phone;
            lh.PatientName = name; 
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<Appointment>("Appointment", lh);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Quang bảo chưa sửa được! ");
                }
            }

        }
        public List<Doctor> LoadDataDoctorComboBox()
        {
            List<Doctor> bs = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"Appointment?getDoctor={true}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Doctor>>();
                    readTask.Wait();

                    bs = readTask.Result;

                }
            }
            return bs.ToList();
        }
        private void EditAppointent_Load(object sender, EventArgs e)
        {
            Appointment lh = new Appointment();
            lh = GetByID(value);
            txtAppointmentID.Text = lh.AppointmentID.ToString();
            txtPhoneNumber.Text = lh.PhoneNumber.ToString();
            cbbDoctor.DataSource = LoadDataDoctorComboBox();
            cbbDoctor.ValueMember = "DoctorID";
            cbbDoctor.DisplayMember = "DoctorName";
            dtpDateAppointment.Value = lh.Date;
            txtPatientName.Text = lh.PatientName.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phone = Convert.ToString(txtPhoneNumber.Text);
            int AppointmentID =Convert.ToInt32(txtAppointmentID.Text) ;
            int DoctorID = Convert.ToInt32(cbbDoctor.SelectedValue);
            DateTime date = dtpDateAppointment.Value;
            string name =Convert.ToString(txtPatientName.Text);
            PutLichHen(AppointmentID, DoctorID, date ,phone,name);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
