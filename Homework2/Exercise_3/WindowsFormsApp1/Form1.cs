//Realized by Matteo Varrecchia
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Imposta valori predefiniti per numericUpDownN e numericUpDownK
            numericUpDownN.Value = 100;
            numericUpDownK.Value = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ottieni i valori da numericUpDownN e numericUpDownK
            int N = (int)numericUpDownN.Value;
            int K = (int)numericUpDownK.Value;

            // Genera dati casuali
            List<int> data = GenerateRandomData(N);

            // Crea l'istogramma
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Interval = 1; // Imposta l'intervallo sull'asse X
            chart1.Series.Clear();

            Series series = new Series("Histogram");
            series.ChartType = SeriesChartType.Column;

            // Calcola l'istogramma
            int[] histogram = CalculateHistogram(data, K);

            // Aggiungi dati all'istogramma
            double columnWidth = 10.0 / K; // Modifica per riflettere l'intervallo di dati (1-10)
            for (int i = 0; i < histogram.Length; i++)
            {
                double lowerBound = i * columnWidth + 1; // Parti da 1 invece di 0
                double upperBound = (i + 1) * columnWidth;
                string interval = string.Format("[{0}-{1}]", lowerBound, upperBound);
                series.Points.AddXY(interval, histogram[i]);
            }

            // Aggiungi la serie al grafico
            chart1.Series.Add(series);
        }

        private List<int> GenerateRandomData(int N)
        {
            Random random = new Random();
            List<int> data = new List<int>();

            for (int i = 0; i < N; i++)
            {
                data.Add(random.Next(1, 11)); // Dati casuali tra 1 e 10 (puoi modificare il range)
            }

            return data;
        }

        private int[] CalculateHistogram(List<int> data, int K)
        {
            int[] histogram = new int[K];

            foreach (int value in data)
            {
                int bin = (int)Math.Floor((value - 1) / (10.0 / K));
                histogram[bin]++;
            }

            return histogram;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
