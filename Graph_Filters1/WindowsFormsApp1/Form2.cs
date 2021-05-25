using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ShowIntensityHistogram(int[] histogram)
        {
            ChartArea ca = new ChartArea();
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = 256;
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = histogram.Max();
            ca.AxisY.Interval = 500;
            chart1.ChartAreas.Add(ca);


            chart1.Series.Add("Intesivity");
            chart1.Series["Intesivity"].XValueType = ChartValueType.Int32;
            chart1.Series["Intesivity"].ChartType = SeriesChartType.Column;
            chart1.Series["Intesivity"]["PointWidth"] = "1";
            chart1.Series["Intesivity"].Points.DataBindY(histogram);
            Show();
        }
        public void ShowRGBHistogram(int[][] histogram)
        {
            ChartArea ca = new ChartArea();
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = 256;
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = Math.Max(histogram[0].Max(), Math.Max(histogram[1].Max(), histogram[2].Max()));
            ca.AxisY.Interval = 1000;
            chart1.ChartAreas.Add(ca);

            chart1.Series.Add("Красный");
            chart1.Series["Красный"].XValueType = ChartValueType.Int32;
            chart1.Series["Красный"].ChartType = SeriesChartType.Column;
            chart1.Series["Красный"].Color = Color.FromArgb(85, Color.Red);
            chart1.Series["Красный"].Points.DataBindY(histogram[0]);
            chart1.Series["Красный"]["PointWidth"] = "1";

            chart1.Series.Add("Зелёный");
            chart1.Series["Зелёный"].XValueType = ChartValueType.Int32;
            chart1.Series["Зелёный"].ChartType = SeriesChartType.Column;
            chart1.Series["Зелёный"].Color = Color.FromArgb(85, Color.Green);
            chart1.Series["Зелёный"].Points.DataBindY(histogram[1]);
            chart1.Series["Зелёный"].MarkerSize = 1;
            chart1.Series["Зелёный"]["PointWidth"] = "1";

            chart1.Series.Add("Синий");
            chart1.Series["Синий"].XValueType = ChartValueType.Int32;
            chart1.Series["Синий"].ChartType = SeriesChartType.Column;
            chart1.Series["Синий"].Color = Color.FromArgb(85, Color.DarkBlue);
            chart1.Series["Синий"].Points.DataBindY(histogram[2]);
            chart1.Series["Синий"]["PointWidth"] = "1";
            chart1.Series["Синий"]["PointWidth"] = "1";
            Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
