using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_iDental.UserControls
{
    public partial class UC_MedicalRecord : UserControl
    {
        public UC_MedicalRecord()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (palBill.Width == 10)
            {
                palBill.Width = 738;
            }
            else
                palBill.Width = 10;
                
        }

        private void palBill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
