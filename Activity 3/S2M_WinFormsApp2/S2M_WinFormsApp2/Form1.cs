namespace S2M_WinFormsApp2
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
            int s;
            int m;
            int m_h;
            int h;
            int h_d;
            int d;
            value = Convert.ToInt32(inputOfSecs.Text);

            if (s2m_radioButton1.Checked == true)
            {
                if(value < 60)
                {
                    s = (value);
                    outputLabel.Text = s.ToString() + " second(s)";
                }
                else if (value >= 60)
                {
                    if (value <= 3599)
                    {
                        m = (value / 60);
                        s = (value % 60);
                        outputLabel.Text = m.ToString() + " minute(s)" + " and " + s.ToString() + " second(s)";
                    }
                    else if(value == 3600)
                    {
                        m_h = (value / 3600);
                        s = (value % 60);
                        m = (value % 60);
                        outputLabel.Text = m_h.ToString() + " hour" + " and " + m.ToString() + " minute(s)" + " and " + s.ToString() + " second(s)";
                    }
                    if(value >= 3601)
                    {
                       if(value <= 86399)
                        {
                            h = (value / 3600);
                            s = (value % 60);
                            m = (value % 60);
                            outputLabel.Text = h.ToString() + " hour(s)" + " and " + m.ToString() + " minute(s)" + " and " + s.ToString() + " second(s)";
                        }
                       else if(value == 86400)
                        {
                            h_d = (value / 86400);
                            h = (value % 3600);
                            s = (value % 60);
                            m = (value % 60);
                            outputLabel.Text = h_d.ToString() + " day" + " and " + h.ToString() + " hour(s)" + " and " + m.ToString() + " minute(s)" + " and " + s.ToString() + " second(s)";
                        }
                       if(value >= 86401)
                        {
                            d = (value / 86400);
                            h = (value % 3600);
                            s = (value % 60);
                            m = (value % 60);
                            outputLabel.Text = d.ToString() + " day(s)" + " and " + h.ToString() + " hour(s)" + " and " + m.ToString() + " minute(s)" + " and " + s.ToString() + " second(s)";
                        }
                    }
                }   
            }
            else
            {
                MessageBox.Show("Please Select an Option");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}