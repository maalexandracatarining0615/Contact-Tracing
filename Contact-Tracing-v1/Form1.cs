namespace Contact_Tracing_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amisafetext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your information is safe with us! Please take care of yourself and your loved ones!");
        }

        private void contacttracinglogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! This is a simple logo I made in Adobe Photoshop using pen tool and shape tool.");
        }

        private void button1linkedtoForm2_Click(object sender, EventArgs e)
        {
            ContactTracingForm f2 = new ContactTracingForm();
            f2.Show();
            this.Hide();
        }

        private void button2linkedtoForm3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}