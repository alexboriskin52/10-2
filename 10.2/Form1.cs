namespace _10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double voltage;
        double resist1;
        double resist2;
        string tip;
        double allresist;
        double sila;
        private void button1_Click(object sender, EventArgs e)
        {
            if (tip == "0")
            {
                allresist = resist1 + resist2;

            }
            else
            {
                allresist = 1 / (1 / resist1 + 1 / resist2);
            }
            sila = voltage/allresist;
         
            MessageBox.Show(Convert.ToString(sila));
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tip = Convert.ToString(comboBox1.SelectedIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            voltage = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            resist1 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            resist2 = double.Parse(textBox3.Text);
        }
    }
}
