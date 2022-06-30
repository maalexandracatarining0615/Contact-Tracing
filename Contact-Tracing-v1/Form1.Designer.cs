namespace Contact_Tracing_v1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contacttracinglogo = new System.Windows.Forms.PictureBox();
            this.amisafetext = new System.Windows.Forms.PictureBox();
            this.button1linkedtoForm2 = new System.Windows.Forms.Button();
            this.button2linkedtoForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contacttracinglogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amisafetext)).BeginInit();
            this.SuspendLayout();
            // 
            // contacttracinglogo
            // 
            this.contacttracinglogo.Image = global::Contact_Tracing_v1.Properties.Resources.contact_tracing_logo;
            this.contacttracinglogo.Location = new System.Drawing.Point(77, 12);
            this.contacttracinglogo.Name = "contacttracinglogo";
            this.contacttracinglogo.Size = new System.Drawing.Size(241, 206);
            this.contacttracinglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contacttracinglogo.TabIndex = 0;
            this.contacttracinglogo.TabStop = false;
            this.contacttracinglogo.Click += new System.EventHandler(this.contacttracinglogo_Click);
            // 
            // amisafetext
            // 
            this.amisafetext.Image = global::Contact_Tracing_v1.Properties.Resources.am_i_safe_text;
            this.amisafetext.Location = new System.Drawing.Point(93, 218);
            this.amisafetext.Name = "amisafetext";
            this.amisafetext.Size = new System.Drawing.Size(208, 117);
            this.amisafetext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amisafetext.TabIndex = 1;
            this.amisafetext.TabStop = false;
            this.amisafetext.Click += new System.EventHandler(this.amisafetext_Click);
            // 
            // button1linkedtoForm2
            // 
            this.button1linkedtoForm2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1linkedtoForm2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1linkedtoForm2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1linkedtoForm2.Location = new System.Drawing.Point(137, 344);
            this.button1linkedtoForm2.Name = "button1linkedtoForm2";
            this.button1linkedtoForm2.Size = new System.Drawing.Size(128, 35);
            this.button1linkedtoForm2.TabIndex = 2;
            this.button1linkedtoForm2.Text = "OKAY!";
            this.button1linkedtoForm2.UseVisualStyleBackColor = false;
            this.button1linkedtoForm2.Click += new System.EventHandler(this.button1linkedtoForm2_Click);
            // 
            // button2linkedtoForm3
            // 
            this.button2linkedtoForm3.Location = new System.Drawing.Point(166, 385);
            this.button2linkedtoForm3.Name = "button2linkedtoForm3";
            this.button2linkedtoForm3.Size = new System.Drawing.Size(75, 23);
            this.button2linkedtoForm3.TabIndex = 3;
            this.button2linkedtoForm3.Text = "button1";
            this.button2linkedtoForm3.UseVisualStyleBackColor = true;
            this.button2linkedtoForm3.Click += new System.EventHandler(this.button2linkedtoForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.button2linkedtoForm3);
            this.Controls.Add(this.button1linkedtoForm2);
            this.Controls.Add(this.amisafetext);
            this.Controls.Add(this.contacttracinglogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact-Tracing-v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contacttracinglogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amisafetext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox contacttracinglogo;
        private PictureBox amisafetext;
        private Button button1linkedtoForm2;
        private Button button2linkedtoForm3;
    }
}