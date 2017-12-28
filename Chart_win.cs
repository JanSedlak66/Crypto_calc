using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crypto_calc
{
    public partial class Chart_win : Form
    {
        Main_win myMain_win;
        int index_data;
        bool close_win_valid = true;

        List<double> memory;


        public Chart_win(Main_win a)
        {
            myMain_win = a;
            InitializeComponent();
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            index_data = 0;
            memory = new List<double>();

            // grafy

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);

            series1.ChartArea = "ChartArea1";
            series2.ChartArea = "ChartArea1";
            series3.ChartArea = "ChartArea1";
            series4.ChartArea = "ChartArea1";
            series5.ChartArea = "ChartArea1";
 
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1.Legends.Add(legend1);
            legend1.Name = "Legend1";

            // legend docked
            chart1.Legends["Legend1"].DockedToChartArea = "ChartArea1";

            series1.Legend = "Legend1";
            series2.Legend = "Legend1";
            series3.Legend = "Legend1";
            series4.Legend = "Legend1";
            series5.Legend = "Legend1";

            series1.Name = "blockchain";
            series2.Name = "bitstamp";
            series3.Name = "poloniex";
            series4.Name = "bitfinex";
            series5.Name = "bittrex";

            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            series1.Color = Color.Red;
            series2.Color = Color.Blue;
            series3.Color = Color.Black;
            series4.Color = Color.Green;
            series5.Color = Color.Yellow;

            this.FormClosed += window_Close; // the chart window is only hide if UserClose window

            this.SizeChanged += window_Resize; // the chart window is only hide if UserClose window
        }

        private void window_Resize(object sender, EventArgs e)
        {
            this.chart1.Size = new Size(this.Size.Width,this.Size.Height); ;
        }

        public void putData(double[] values){

            chart1.Series["blockchain"].Points.AddXY(index_data, values[0]);
            chart1.Series["bitstamp"].Points.AddXY(index_data, values[1]);
            chart1.Series["poloniex"].Points.AddXY(index_data, values[2]);
            chart1.Series["bitfinex"].Points.AddXY(index_data, values[3]);
            chart1.Series["bittrex"].Points.AddXY(index_data, values[4]);
            index_data++;

            // buffer for scale comutation of Y data axis
            for (int i = 0; i <= 4; i++) {
                if (values[i] != 0)
                {
                    memory.Add(values[i]);
                }
            }

            double average = Math.Round(memory.Average());

            chart1.ChartAreas[0].AxisY2.Maximum = average + 500;
            chart1.ChartAreas[0].AxisY2.Minimum = average - 500;

            chart1.ChartAreas[0].AxisY.Maximum = average + 500;
            chart1.ChartAreas[0].AxisY.Minimum = average - 500;
            
        }

        private void window_Close(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                close_win_valid = false;
                this.Visible = false;
            }
            else
            {
                close_win_valid = true;
            }
        }

    }
}
