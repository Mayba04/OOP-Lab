namespace OOP
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {

            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            try
            {
                float a = float.Parse(t1);
                float b = float.Parse(t2);
                float c = float.Parse(t3);

                if (a > 0 && b > 0 && c > 0)
                {
                    AreaTriangle model = new AreaTriangle(a, b, c);
                    textBox4.Text = model.Calcilation().ToString();
                }
                else
                {
                    MessageBox.Show("Such is triangle does not exist");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}