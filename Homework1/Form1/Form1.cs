using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Paint += PictureBox2_Paint;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Puoi aggiungere qui azioni in risposta al clic sulla pictureBox2, se necessario.
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            // Creare un oggetto Graphics
            Graphics g = e.Graphics;

            // Calcolare le dimensioni del rettangolo e i margini per centrare
            int rectWidth = 150;
            int rectHeight = 120;
            int marginX = (pictureBox2.Width - rectWidth) / 2;
            int marginY = (pictureBox2.Height - rectHeight) / 2;

            // Creare una penna con il colore blu e uno spessore di 2 pixel
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                // Disegnare il rettangolo centrato
                g.DrawRectangle(pen, marginX, marginY, rectWidth, rectHeight);
            }

            // Disegnare un punto verde centrato sotto il rettangolo
            using (Brush brush = new SolidBrush(Color.Green))
            {
                g.FillRectangle(brush, marginX + rectWidth / 2 - 2.5f, marginY + rectHeight + 20, 5, 5);
            }

            // Disegnare una linea rossa centrata sotto il rettangolo
            using (Pen linePen = new Pen(Color.Red, 2))
            {
                g.DrawLine(linePen, marginX, marginY + rectHeight + 30, marginX + rectWidth, marginY + rectHeight + 30);
            }

            // Disegnare un cerchio viola centrato sotto il rettangolo
            using (Pen circlePen = new Pen(Color.Purple, 2))
            {
                g.DrawEllipse(circlePen, marginX + rectWidth + 20, marginY + rectHeight, 30, 30);
            }
        }
    }
}
