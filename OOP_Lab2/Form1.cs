namespace OOP_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                QuadraticEquation equation = new QuadraticEquation(a, b, c);

                float discriminant = equation.HasRealSolutions();

                if (discriminant != float.NaN)
                {
                    if (discriminant > 0)
                    {
                        float root1 = (float)((-(b) + Math.Sqrt(discriminant)) / (2 * a));
                        float root2 = (float)(-(b) - Math.Sqrt(discriminant)) / (2 * a);
                        label5.Text = $"The equation has two real roots: x1 = {root1}, x2 = {root2}";
                    }
                    else if (discriminant == 0)
                    {
                        double root = -(b) / (2 * a);
                        label5.Text = $"The equation has one real root: x = {root}";
                    }
                }
                else
                {
                    label5.Text = "A quadratic equation has no real solutions.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}