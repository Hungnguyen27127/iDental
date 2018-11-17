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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }
        int value;
        public AddAppointment(int AppointmentID): this()
        {
            value = AppointmentID ;
            //txtAppointmentID.Text = value.ToString();
        } 
        public string baseAddress = "http://localhost:55965/api/";
        // apipostnew
       
        public void ThemLichHen(int DoctorID, DateTime date)
        {
         
            Appointment lh = new Appointment();
            
            lh.EmployeeID = DoctorID ;
            lh.Date = date;          
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Appointment>("Appointment", lh);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
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
            
            //int AppointmentID =Convert.ToInt32(txtAppointmentID.Text) ;
            ThemLichHen(DoctorID, date);
         
        }
     

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            cbbDoctor.DataSource = LoadDataDoctorComboBox();
            cbbDoctor.ValueMember = "DoctorID";
            cbbDoctor.DisplayMember = "DoctorName";
        }
    }
}
