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
    public partial class UC_Appointment : UserControl
    {
        public UC_Appointment()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:55965/api/";
        public void BindingData()
        {
            txtAppointment.DataBindings.Clear();
            txtAppointment.DataBindings.Add("Text", dgvLichHen.DataSource, "AppointmentID");
        }

        // api 

        // Getall
        public List<AppointmentShow> GetAll()
        {
            IEnumerable<AppointmentShow> lichhen = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Appointment");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AppointmentShow>>();
                    readTask.Wait();

                    lichhen = readTask.Result;
                }
                else
                {
                    lichhen = Enumerable.Empty<AppointmentShow>();

                }
            }
            return lichhen.ToList();
        }
        //getDoctor
        //public List<Doctor> LoadDataDoctorComboBox()
        //{
        //    List<Doctor> bs = null;
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseAddress);
        //        //HTTP GET
        //        var responseTask = client.GetAsync($"Appointment?getDoctor={true}");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsAsync<List<Doctor>>();
        //            readTask.Wait();

        //            bs = readTask.Result;

        //        }
        //    }
        //    return bs.ToList();
        //}
        // delete 
        public void DeleteAppointment(int AppointmentID)
        {
          
 
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseAddress);
                var responseTask = client.DeleteAsync("Appointment?AppointmentID=" + AppointmentID);
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


        //call api   
        private void UC_Appointment_Load(object sender, EventArgs e)
        {
            //List<Doctor> bs = LoadDataDoctorComboBox();
            //int count = bs.Count;
            //foreach (var itemm in bs)
            //{
            //    cbbDoctor.ValueMember = itemm.DoctorID.ToString();
            //    cbbDoctor.DisplayMember = itemm.DoctorName;
            //}
            dgvLichHen.DataSource = GetAll();
            BindingData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (dgvLichHen.RowCount > 1)
            {
            
                for (int  i = 0; i <=dgvLichHen.RowCount;i++)
                {
                    Count++;
                }
            }
            
            using (AddAppointment add = new AddAppointment(Count))
            {              
                add.ShowDialog();              
            }
            dgvLichHen.DataSource = GetAll();
            BindingData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // txtAppointment.ReadOnly = true;
            int a = Convert.ToInt32(txtAppointment.Text);
            DeleteAppointment(a);
            dgvLichHen.DataSource = GetAll();
            BindingData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // gọi api lấy dữ liệu theo mã 

            using (EditAppointent edit = new EditAppointent(Convert.ToInt32(txtAppointment.Text)))
            {
                edit.ShowDialog();
            }
            dgvLichHen.DataSource = GetAll();
            BindingData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
