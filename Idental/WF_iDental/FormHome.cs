using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_iDental.UserControls;
using Data_iDental.Entities;
using System.Net.Http;

namespace WF_iDental
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            timerTime.Start();
        }
       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void moveSidePanel(Control btn)
        {
            palMove.Top = btn.Top;
            palMove.Height = btn.Height;
        }
        private void addUserControl(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            palUC.Controls.Clear();
            palUC.Controls.Add(uc);
        }
    
        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quang đang muốn tắt phải không ?", "Quang depzai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLichHen);
            UC_Appointment uch = new UC_Appointment();
            addUserControl(uch);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home f = new UC_Home();
            addUserControl(f);
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBenhNhan);
             UC_Patient f = new UC_Patient();
            addUserControl(f);
        }

       

        private void btnautosize_Click(object sender, EventArgs e)
        {
            if (palMenuLeft.Width == 250)
            {
                palMenuLeft.Width = 88;
            }
            else
                palMenuLeft.Width = 250;
            if (palMenuLeft.Width == 88)
            {
                labName.Hide();
               

            }
        }

        private void palMenuLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMeterials_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnMeterials);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnReport);
        }

        private void btnKhamChua_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKhamChua);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDichVu);
            UC_Service s = new UC_Service();
            addUserControl(s);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home f = new UC_Home();
            addUserControl(f);
        }

        private void palTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now ;
            labTime.Text = dt.ToString("HH:mm:ss"); 
        }
    }
}
