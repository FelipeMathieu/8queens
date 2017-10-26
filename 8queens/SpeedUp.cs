using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8queens
{
    public partial class SpeedUp : Form
    {
        private double[] times;
        private int[] cores = new int[4];

        public SpeedUp(double[] times)
        {
            InitializeComponent();
            this.times = times;
            this.cores[0] = 1;
            this.cores[1] = 2;
            this.cores[2] = 4;
            this.cores[3] = 8;

            this.chart1.ChartAreas[0].AxisX.Title = "NÚMERO DE CORES";
            this.chart1.ChartAreas[0].AxisY.Title = "TEMPO DE EXECUÇÃO";

            this.chart1.Series[0].LegendText = "SERIAL";
            this.chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            this.chart1.Series[1].LegendText = "2 CORES";
            this.chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            this.chart1.Series[2].LegendText = "4 CORES";
            this.chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            this.chart1.Series[3].LegendText = "8 CORES";
        }
    }
}
