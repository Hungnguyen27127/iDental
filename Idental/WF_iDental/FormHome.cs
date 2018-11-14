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
            moveSidePanel(btnHome);
            UC_Appointment uch = new UC_Appointment();
            addUserControl(uch);
        }

      
    }
}
