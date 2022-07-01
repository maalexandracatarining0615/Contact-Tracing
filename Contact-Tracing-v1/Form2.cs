using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Contact_Tracing_v1
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTracingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Brgy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\USER\source\repos\Contact-Tracing-v1\Contact-Tracing-v1\RespondentsList.txt");
            file.WriteLine("First Name: " + FirstN.Text);
            file.WriteLine("Middle Name: " + MidN.Text);
            file.WriteLine("Last Name: " + LastN.Text);
            file.WriteLine("Age: " + AgeBox.Text);
            file.WriteLine("Gender: " + GndrBox.Text);
            file.WriteLine("Body Temperature: " + TempBox.Text);
            file.WriteLine("Region: " + RegionBox.Text);
            file.WriteLine("Province: " + ProvBox.Text);
            file.WriteLine("Municilapity: " + CityBox.Text);
            file.WriteLine("Barangay: " + BrgyBox.Text);
            file.WriteLine("Email Address: " + EmailAd.Text);
            file.WriteLine("Contact Number: " + ContactNo.Text);
            file.WriteLine("Date and Time: " + DateandTime.Text);
            file.WriteLine("Nature of Visit: " + VisitPurpose.Text);

            file.WriteLine(" ");
            file.WriteLine(" ===================");
            file.WriteLine(" ");
            file.Close();

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
