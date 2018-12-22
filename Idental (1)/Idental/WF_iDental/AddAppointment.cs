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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }
        int value;
        public AddAppointment(int AppointmentID) : this()
        {
            value = AppointmentID;
            //txtAppointmentID.Text = value.ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        public string baseAddress = "http://localhost:55965/api/";
        public void ThemLichHen(int DoctorID, DateTime date , string Name , string phone)
        {
         
            Appointment lh = new Appointment();
            
            lh.EmployeeID = DoctorID ;
            lh.Date = date;
            lh.PatientName = Name;
            lh.PhoneNumber = phone;    
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Appointment>("Appointment", lh);
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int DoctorID = Convert.ToInt32(cbbDoctor.SelectedValue);
            DateTime date = dtpDateAppointment.Value;
            string Name = Convert.ToString(txtName.Text);
            string phone = Convert.ToString(txtPhoneNumber.Text);
            //int AppointmentID =Convert.ToInt32(txtAppointmentID.Text) ;
            ThemLichHen(DoctorID, date,Name, phone);

         
        }
        private void AddAppointment_Load(object sender, EventArgs e)
        {
            cbbDoctor.DataSource = LoadDataDoctorComboBox();
            cbbDoctor.ValueMember = "DoctorID";
            cbbDoctor.DisplayMember = "DoctorName";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
