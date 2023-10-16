using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeworkInC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dati forniti manualmente
            string data1 = @"Eta,Main Hobbies,Height
                            22,Gaming,1.73
                            22,CTFs,1.8
                            23,Crafting,1.72
                            23,Workout,1.8
                            21,Football,1.68
                            23,Skiing,1.81
                            23,Pro gaming,1.86
                            24,Reading,1.71
                            24,Gaming,1.91
                            23,Football,1.8
                            21,Longboard,1.65
                            25,Sports,1.82
                            22,Gym,1.95
                            22,Gaming,1.9
                            22,Gaming,1.77
                            25,Sports,1.7
                            21,Playing music,1.78
                            21,Listening to Music,1.91
                            21,Reading,1.82
                            23,Sports,1.9
                            22,Gym,
                            21,Gaming,
                            23,Sports,Watching movies
                            24,Dancing,Cooking
                            25,Sports,Sports
                            23,Music,Sport
                            22,Football,Trekking
                            22,Travel,Traveling
                            22,Sports,Sports
                            27,Climbing,Music
                            23,Videogames,Hiking
                            24,Listening to Music,Cooking
                            22,Workout,Music
                            22,Reading,Gym
                            22,Listening to Music,Football
                            23,Trekking,Sport
                            27,Gym,Gym
                            23,Music,Music
                            25,Motorbike,Gaming
                            23,Gaming,Gaming";

            string data2 = @"Enterpreneurial attitude,Age
                            2,22
                            3,22
                            3,23
                            3,23
                            3,21
                            4,23
                            3,23
                            3,24
                            3,24
                            4,23
                            2,21
                            3,25
                            1,22
                            3,22
                            4,22
                            3,25
                            2,21
                            3,21
                            4,21
                            4,23
                            3,22
                            2,21
                            4,23
                            2,24
                            2,25
                            3,23
                            3,22
                            3,27
                            3,23
                            3,24
                            3,22
                            4,25
                            3,26
                            4,22
                            5,22
                            4,22
                            5,23
                            2,27
                            2,23
                            5,23
                            0,25
                            3,26
                            4,22
                            3,22
                            4,22
                            5,23
                            3,23
                            5,26
                            2,27
                            4,23
                            2,23
                            4,23
                            3,27
                            4,24";

            // Split dei dati in righe e colonne
            var rows1 = data1.Split('\n').Select(row => row.Split(','));
            var rows2 = data2.Split('\n').Select(row => row.Split(','));

            // Calcolo delle frequenze
            CalculateAndDisplayFrequencies(rows1.Skip(1).ToArray(), rows2.Skip(1).ToArray()); // Skip the header rows
        }

        private void CalculateAndDisplayFrequencies(string[][] data1, string[][] data2)
        {
            // Calcola le frequenze per ogni variabile
            var ageFrequencies = CalculateFrequencies(data1, 0); // Eta
            var hobbiesFrequencies = CalculateFrequencies(data1, 1); // Hobbies
            var heightFrequencies = CalculateFrequencies(data1, 2); // Height

            // Calcola le frequenze per la joint distribution
            var jointDistributionFrequencies = CalculateJointDistributionFrequencies(data2);

            // Visualizza le tabelle HTML con le frequenze
            DisplayTable(dataGridView1, ageFrequencies, "Age");
            DisplayTable(dataGridView2, hobbiesFrequencies, "Main Hobbies");
            DisplayTable(dataGridView3, heightFrequencies, "Height");
            DisplayTable(dataGridViewJointDistribution, jointDistributionFrequencies, "Enterpreneurial Attitude and Age");
        }

        private Dictionary<string, int> CalculateFrequencies(string[][] data, int columnIndex)
        {
            var frequencies = new Dictionary<string, int>();

            foreach (var row in data)
            {
                if (row.Length > columnIndex)
                {
                    var value = row[columnIndex].Trim();
                    frequencies[value] = frequencies.ContainsKey(value) ? frequencies[value] + 1 : 1;
                }
            }

            return frequencies;
        }

        private Dictionary<string, int> CalculateJointDistributionFrequencies(string[][] data)
        {
            var frequencies = new Dictionary<string, int>();

            foreach (var row in data)
            {
                if (row.Length == 2)
                {
                    var key = $"{row[0].Trim()}, {row[1].Trim()}";
                    frequencies[key] = frequencies.ContainsKey(key) ? frequencies[key] + 1 : 1;
                }
            }

            return frequencies;
        }

        private void DisplayTable(DataGridView dataGridView, Dictionary<string, int> frequencies, string variable)
        {
            // Pulisce il DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Aggiunge le colonne al DataGridView
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("Absolute Frequency", "Absolute Frequency");
            dataGridView.Columns.Add("Relative Frequency", "Relative Frequency");
            dataGridView.Columns.Add("Percentage", "Percentage");

            var total = frequencies.Values.Sum();

            foreach (var entry in frequencies)
            {
                var key = entry.Key;
                var value = entry.Value;
                var relativeFrequency = (double)value / total;
                var percentage = (relativeFrequency * 100).ToString("0.00") + '%';

                // Aggiunge una riga al DataGridView
                dataGridView.Rows.Add(key, value, relativeFrequency.ToString("0.00"), percentage);
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
