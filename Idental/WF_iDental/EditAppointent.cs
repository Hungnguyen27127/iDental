﻿using Data_iDental.Entities;
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
    public partial class EditAppointent : Form
    {
        public EditAppointent()
        {
            InitializeComponent();
        }
        int value; 
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
                   

                }
            }
            return lichhen;
        }
        public void PutLichHen(int AppointmentID, int DoctorID, DateTime date)
        {

            Appointment lh = new Appointment();
            lh.AppointmentID = AppointmentID;
            lh.EmployeeID = DoctorID;
            lh.Date = date;
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
        private void EditAppointent_Load(object sender, EventArgs e)
        {
            Appointment lh = new Appointment();
            lh = GetByID(value);
            txtDoctorID.Text = lh.EmployeeID.ToString();
            txtAppointmentID.Text = lh.AppointmentID.ToString();
            dtpDateAppointment.Value = lh.Date;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int AppointmentID =Convert.ToInt32(txtAppointmentID.Text) ;
            int DoctorID = Convert.ToInt32(txtDoctorID.Text);
            DateTime date = dtpDateAppointment.Value;
            PutLichHen(AppointmentID, DoctorID, date);
        }
    }
}
