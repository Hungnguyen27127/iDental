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
using System.Windows.Forms.DataVisualization.Charting;

namespace WF_iDental.UserControls
{
    public partial class UC_Statistic : UserControl
    {
        
            public string baseAddress = "http://localhost:10737/api/";
        public UC_Statistic()
        {
            InitializeComponent();
        }
        public List<Statistic> GetTK(DateTime date1, DateTime date2)
        {
            IEnumerable<Statistic> TK = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Statistic?date1=" + date1 + "&date2=" + date2);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Statistic>>();
                    readTask.Wait();
                    
                    TK = readTask.Result;
                  
                }
                else
                {
                    TK = Enumerable.Empty<Statistic>();

                }
            }
            return TK.ToList();
        }
        public List<NumberOfPatient> GetNOP()
        {
            IEnumerable<NumberOfPatient> TK = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("Statistic");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<NumberOfPatient>>();
                    readTask.Wait();

                    TK = readTask.Result;

                }
                else
                {
                    TK = Enumerable.Empty<NumberOfPatient>();

                }
            }
            return TK.ToList();
        }
        public List<TKService> GetTKService()
        {
            IEnumerable<TKService> TK = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("TKService");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<TKService>>();
                    readTask.Wait();

                    TK = readTask.Result;

                }
                else
                {
                    TK = Enumerable.Empty<TKService>();

                }
            }
            return TK.ToList();
        }
        private void labTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            if (comboBox1.Text == "Thống kê các dịch vụ và số người sử dụng")
            {
                chart1.Series["Dịch vụ"]["PixelPointWidth"] = "15";
                List<TKService> temp = GetTKService();
                for (int i = 0; i < temp.Count; i++)
                {
                    chart1.Series["Dịch vụ"].Points.AddXY(temp[i].ServiceName, temp[i].NumberOfuse);
                    
                }
                int blockSize = 200;
                Random rand = new Random();
                var valuesArray = Enumerable.Range(0, blockSize * 30).Select(x => rand.Next(1, 10)).ToArray();
                var chartArea = chart1.ChartAreas[chart1.Series["Dịch vụ"].ChartArea];
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = temp.Count;
                chartArea.CursorX.AutoScroll = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);
                chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
            }
            if (comboBox1.Text == "Thống kê theo khoảng thời gian")
            {
                chart1.Series["Bệnh nhân"]["PixelPointWidth"] = "15";
                List<Statistic> temp = GetTK(date1.Value, date2.Value);
                for (int i = 0; i < temp.Count; i++)
                {

                    chart1.Series["Bệnh nhân"].Points.AddXY(temp[i].DateOfCreate.ToString("M/dd"), temp[i].PatientNumber);
                    
                }
                int blockSize = 200;
                Random rand = new Random();
                var valuesArray = Enumerable.Range(0, blockSize * 30).Select(x => rand.Next(1, 10)).ToArray();
                var chartArea = chart1.ChartAreas[chart1.Series["Bệnh nhân"].ChartArea];
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = temp.Count;
                chartArea.CursorX.AutoScroll = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);
                chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
            }
            
            if (comboBox1.Text == "Thống kê số bệnh nhân của từng bác sĩ")
            {
                chart1.Series["Bệnh nhân"]["PixelPointWidth"] = "15";
                List<NumberOfPatient> temp = GetNOP();
                for (int i = 0; i < temp.Count; i++)
                {
                    chart1.Series["Bệnh nhân"].Points.AddXY(temp[i].EmployeeName, temp[i].PatientNumber);
                }
                int blockSize = 100;
                Random rand = new Random();
                var valuesArray = Enumerable.Range(0, blockSize * 30).Select(x => rand.Next(1, 10)).ToArray();
                var chartArea = chart1.ChartAreas[chart1.Series["Bệnh nhân"].ChartArea];
                
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = temp.Count;
                chartArea.CursorX.AutoScroll = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);
                chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
            }
            //chart1.Series["Bệnh nhân"].XValueMember = "DateOfCreate";
            //chart1.Series["Bệnh nhân"].YValueMembers = "PatientNumber";
            //chart1.DataSource = temp;
            //chart1.DataBind();
        }
        
        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Thống kê theo khoảng thời gian")
            {
                date1.Enabled = true;
                date2.Enabled = true;
                List<Statistic> temp = GetTK(date1.Value, date2.Value);
                for (int i = 0; i < temp.Count; i++)
                {
                    chart1.Series["Bệnh nhân"].Points.AddXY(temp[i].DateOfCreate.ToString("dd/M/yyyy"), temp[i].PatientNumber);
                }
            }

            if (comboBox1.Text == "Thống kê số bệnh nhân của từng bác sĩ")
            {
                date1.Enabled = false;
                date2.Enabled = false;
                
            }
            if (comboBox1.Text == "Thống kê các dịch vụ và số người sử dụng")
            {
                date1.Enabled = false;
                date2.Enabled = false;
                
            }
        }
    }
}
