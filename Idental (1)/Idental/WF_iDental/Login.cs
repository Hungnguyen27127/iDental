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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string baseAddress = "http://localhost:51624/api/";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Account logiN(string username)
        {
            Account TK = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Login?username=" + username);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Account>();
                    readTask.Wait();

                    TK = readTask.Result;
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công !");

                }
            }
            return TK;

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int accountID;
            Account login = logiN(txtUsername.Text);

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
            }
            else
            {
                if (txtUsername.Text == "") { MessageBox.Show("Bạn chưa nhập mật khẩu!"); }
                else
                {
                    if (login == null)
                    {
                        MessageBox.Show("Bạn đã nhập sai tên tài khoản!");
                    }
                    else
                    {
                        if (login.Password == txtPassword.Text)
                        {
                            accountID = login.AccountID;
                            this.Visible = false;
                            formHome fh = new formHome(accountID);
                            fh.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã nhập sai mật khẩu");

                        }
                    }
                }
            }
        }

        private void palTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {

        }
    }
}
