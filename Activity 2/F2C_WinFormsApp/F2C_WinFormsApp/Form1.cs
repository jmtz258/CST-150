namespace F2C_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int c;
            int f;
            value = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                //c = (value - 32) * (5/9);
                c = (int)((value - 32) * (0.556));
                label3.Text = c.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                //f = (value * (9/5)) + 32;
                f = (int)((value * 1.8) + 32);
                label3.Text = f.ToString();
            }
            else
            {
                MessageBox.Show("Please Select an Option");
            }
        }
    }
}