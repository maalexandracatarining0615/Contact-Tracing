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
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\USER\source\repos\Contact-Tracing-v1\Contact-Tracing-v1\RespondentsList.txt", true);
            file.WriteLine("First Name: " + FirstN.Text);
            file.WriteLine("Middle Name: " + MidN.Text);
            file.WriteLine("Last Name: " + LastN.Text);
            file.WriteLine("Suffix: " + Suffix.Text);
            file.WriteLine("Age: " + AgeBox.Text);
            file.WriteLine("Sex: " + SexBox.Text);
            file.WriteLine("Body Temperature: " + TempBox.Text);
            file.WriteLine("Region: " + RegionPicker.Text);
            file.WriteLine("Province: " + ProvBox.Text);
            file.WriteLine("Municilapity: " + CityBox.Text);
            file.WriteLine("Barangay: " + BrgyBox.Text);
            file.WriteLine("Email Address: " + EmailAd.Text);
            file.WriteLine("Contact Number: " + ContactNo.Text);
            file.WriteLine("Date and Time: " + DateandTime.Text);
            file.WriteLine("Nature of Visit: " + VisitPurpose.Text);
         

            file.WriteLine(" ");
            file.WriteLine("=====================================");
            file.WriteLine(" ");
            file.Close();

            FirstN.Text = "";
            MidN.Text = "";
            LastN.Text = "";
            Suffix.Text = "";
            AgeBox.Text = "";
            SexBox.Text = "";
            TempBox.Text = "";
            RegionPicker.Text = "";
            ProvBox.Text = "";
            CityBox.Text = "";
            BrgyBox.Text = "";
            EmailAd.Text = "";
            ContactNo.Text = "";
            DateandTime.Text = "";
            VisitPurpose.Text = "";


            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstN_Enter(object sender, EventArgs e)
        {
            if (FirstN.Text == "JUAN")
            {
                FirstN.Text = "";
                FirstN.ForeColor = Color.Black;
            }

        }

        private void FirstN_Leave(object sender, EventArgs e)
        {
            if(FirstN.Text == "")
            {
                FirstN.Text = "JUAN";
                FirstN.ForeColor = Color.Silver;
            }
        }

        private void MidN_Enter(object sender, EventArgs e)
        {
            if(MidN.Text == "PEREZ")
            {
                MidN.Text = "";
                MidN.ForeColor = Color.Black;
            }
        }

        private void LastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void MidN_Leave(object sender, EventArgs e)
        {
            if (MidN.Text == "")
            {
                MidN.Text = "PEREZ";
                MidN.ForeColor = Color.Silver;
            }
        }

        private void Suffix_Enter(object sender, EventArgs e)
        {
            if (Suffix.Text == "ex. JR., SR.")
            {
                Suffix.Text = "";
                Suffix.ForeColor = Color.Black;
            }
        }

        private void Suffix_Leave(object sender, EventArgs e)
        {
            if (Suffix.Text == "")
            {
                Suffix.Text = "ex. JR., SR.";
                Suffix.ForeColor = Color.Silver;
            }
        }

        private void LastN_Enter(object sender, EventArgs e)
        {
            if (LastN.Text == "DELA CRUZ")
            {
                LastN.Text = "";
                LastN.ForeColor = Color.Black;
            }
        }

        private void EmailAd_Enter(object sender, EventArgs e)
        {
            if (EmailAd.Text == "ex. username@gmail.com")
            {
                EmailAd.Text = "";
                EmailAd.ForeColor = Color.Black;
            }
        }

        private void LastN_Leave(object sender, EventArgs e)
        {
            if (LastN.Text == "")
            {
                LastN.Text = "DELA CRUZ";
                LastN.ForeColor = Color.Silver;
            }
        }

        private void EmailAd_Leave(object sender, EventArgs e)
        {
            if (EmailAd.Text == "")
            {
                EmailAd.Text = "ex. username@gmail.com";
                EmailAd.ForeColor = Color.Silver;
            }
        }

        private void ContactNo_Enter(object sender, EventArgs e)
        {
            if (ContactNo.Text == "09459871236")
            {
                ContactNo.Text = "";
                ContactNo.ForeColor = Color.Black;
            }
        }

        private void ContactNo_Leave(object sender, EventArgs e)
        {
            if (ContactNo.Text == "")
            {
                ContactNo.Text = "09459871236";
                ContactNo.ForeColor = Color.Silver;
            }
        }
    }
}
