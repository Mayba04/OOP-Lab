using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab7
{
    public partial class Form1 : Form
    {
        Graphics graph;
        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void DrawGraph()
        {
            graph.Clear(BackColor);
            Point buttonLocation = PointToClient(button1.PointToScreen(Point.Empty));

            int width = ClientSize.Width;
            int height = ClientSize.Height;

            double scaleX = (width - buttonLocation.X) / (0.9 - 0.2);

            double scaleY = height / (CalculateY(0.9) - CalculateY(0.2));

            Color slateBlue = Color.FromName("SlateBlue");
            float penWidth = 2;
            Pen pen = new Pen(slateBlue, penWidth);

            double xPrev = 0;
            double yPrev = CalculateY(0.2);

            for (double x = 0.2; x <= 0.9; x += 0.15)
            {
                double y = CalculateY(x);
                int x1 = (int)((xPrev - 0.2) * scaleX);
                int y1 = (int)((yPrev - CalculateY(0.2)) * scaleY);
                int x2 = (int)((x - 0.2) * scaleX);
                int y2 = (int)((y - CalculateY(0.2)) * scaleY);

                graph.DrawLine(pen, x1, y1, x2, y2);

                xPrev = x;
                yPrev = y;
            }
        }

        private double CalculateY(double x)
        {
            return Math.Log(Math.Abs(x + 1)) + 5 / (2 * x + 3);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}