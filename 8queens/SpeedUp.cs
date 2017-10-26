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
            this.times = new double[4];
            this.times[0] = 33;
            this.times[1] = 13.78;
            this.times[2] = 7.97;
            this.times[3] = 3.50;


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

            this.printChart();
        }

        private void printChart()
        {
            this.printSerial();
            this.print2Cores();
            this.print4Cores();
            this.print8Cores();
        }

        private void printSerial()
        {
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart1.Series[0].MarkerSize = 4;

            this.chart1.Series[0].Points.SuspendUpdates();
            for (int i = 0; i < 2; i++)
            {
                if(i == 0)
                {
                    this.chart1.Series[0].Points.AddXY(0, 0);
                    this.chart1.Series[0].Points[i].ToolTip = "Tempo: 0 seg";
                }
                else
                {
                    this.chart1.Series[0].Points.AddXY(this.cores[0], this.times[0]);
                    this.chart1.Series[0].Points[i].ToolTip = "Tempo: " + this.times[0].ToString() + " seg";
                }
            }
            this.chart1.Series[0].Points.ResumeUpdates();
        }

        private void print2Cores()
        {
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart1.Series[1].MarkerSize = 4;

            this.chart1.Series[1].Points.SuspendUpdates();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    this.chart1.Series[1].Points.AddXY(0, 0);
                    this.chart1.Series[1].Points[i].ToolTip = "Tempo: 0 seg";
                }
                else
                {
                    this.chart1.Series[1].Points.AddXY(this.cores[1], this.times[1]);
                    this.chart1.Series[1].Points[i].ToolTip = "Tempo: " + this.times[1].ToString() + " seg";
                }
            }
            this.chart1.Series[1].Points.ResumeUpdates();
        }

        private void print4Cores()
        {
            this.chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[2].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart1.Series[2].MarkerSize = 4;

            this.chart1.Series[2].Points.SuspendUpdates();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    this.chart1.Series[2].Points.AddXY(0, 0);
                    this.chart1.Series[2].Points[i].ToolTip = "Tempo: 0 seg";
                }
                else
                {
                    this.chart1.Series[2].Points.AddXY(this.cores[2], this.times[2]);
                    this.chart1.Series[2].Points[i].ToolTip = "Tempo: " + this.times[2].ToString() + " seg";
                }
            }
            this.chart1.Series[2].Points.ResumeUpdates();
        }

        private void print8Cores()
        {
            this.chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[3].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart1.Series[3].MarkerSize = 4;

            this.chart1.Series[3].Points.SuspendUpdates();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    this.chart1.Series[3].Points.AddXY(0, 0);
                    this.chart1.Series[3].Points[i].ToolTip = "Tempo: 0 seg";
                }
                else
                {
                    this.chart1.Series[3].Points.AddXY(this.cores[3], this.times[3]);
                    this.chart1.Series[3].Points[i].ToolTip = "Tempo: " + this.times[3].ToString() + " seg";
                }
            }
            this.chart1.Series[3].Points.ResumeUpdates();
        }
    }
}
