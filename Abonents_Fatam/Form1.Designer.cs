namespace Abonents_Fatam
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.find_surname = new System.Windows.Forms.Button();
            this.find_name = new System.Windows.Forms.Button();
            this.find_otch = new System.Windows.Forms.Button();
            this.find_passport = new System.Windows.Forms.Button();
            this.find_address = new System.Windows.Forms.Button();
            this.Show_all = new System.Windows.Forms.Button();
            this.find_phone = new System.Windows.Forms.Button();
            this.find_device = new System.Windows.Forms.Button();
            this.find_license = new System.Windows.Forms.Button();
            this.find_line = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(116, 35);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(204, 29);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(13, 332);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 25;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1036, 229);
            this.GridView.TabIndex = 3;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 263);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(862, 263);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 29);
            this.txtName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Passport:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Otchestvo:";
            // 
            // txtOtch
            // 
            this.txtOtch.Location = new System.Drawing.Point(116, 123);
            this.txtOtch.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.Size = new System.Drawing.Size(204, 29);
            this.txtOtch.TabIndex = 11;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(116, 165);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(204, 29);
            this.txtPassport.TabIndex = 12;
            this.txtPassport.TextChanged += new System.EventHandler(this.txtPassport_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 209);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 29);
            this.txtAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone_number:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(630, 30);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 29);
            this.txtPhone.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Device:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "License:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Testing_line:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(630, 78);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(4);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(204, 29);
            this.txtDevice.TabIndex = 20;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(630, 121);
            this.txtLicense.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(204, 29);
            this.txtLicense.TabIndex = 21;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(630, 164);
            this.txtTest.Margin = new System.Windows.Forms.Padding(4);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(204, 29);
            this.txtTest.TabIndex = 22;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 217);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // find_surname
            // 
            this.find_surname.Location = new System.Drawing.Point(328, 35);
            this.find_surname.Margin = new System.Windows.Forms.Padding(4);
            this.find_surname.Name = "find_surname";
            this.find_surname.Size = new System.Drawing.Size(130, 30);
            this.find_surname.TabIndex = 24;
            this.find_surname.Text = "Find_surname";
            this.find_surname.UseVisualStyleBackColor = true;
            this.find_surname.Click += new System.EventHandler(this.button5_Click);
            // 
            // find_name
            // 
            this.find_name.Location = new System.Drawing.Point(328, 81);
            this.find_name.Margin = new System.Windows.Forms.Padding(4);
            this.find_name.Name = "find_name";
            this.find_name.Size = new System.Drawing.Size(130, 30);
            this.find_name.TabIndex = 25;
            this.find_name.Text = "Find_name";
            this.find_name.UseVisualStyleBackColor = true;
            this.find_name.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // find_otch
            // 
            this.find_otch.Location = new System.Drawing.Point(328, 126);
            this.find_otch.Margin = new System.Windows.Forms.Padding(4);
            this.find_otch.Name = "find_otch";
            this.find_otch.Size = new System.Drawing.Size(130, 30);
            this.find_otch.TabIndex = 26;
            this.find_otch.Text = "Find_otch";
            this.find_otch.UseVisualStyleBackColor = true;
            this.find_otch.Click += new System.EventHandler(this.find_otch_Click);
            // 
            // find_passport
            // 
            this.find_passport.Location = new System.Drawing.Point(328, 168);
            this.find_passport.Margin = new System.Windows.Forms.Padding(4);
            this.find_passport.Name = "find_passport";
            this.find_passport.Size = new System.Drawing.Size(130, 30);
            this.find_passport.TabIndex = 27;
            this.find_passport.Text = "Find_passport";
            this.find_passport.UseVisualStyleBackColor = true;
            this.find_passport.Click += new System.EventHandler(this.find_passport_Click);
            // 
            // find_address
            // 
            this.find_address.Location = new System.Drawing.Point(328, 208);
            this.find_address.Margin = new System.Windows.Forms.Padding(4);
            this.find_address.Name = "find_address";
            this.find_address.Size = new System.Drawing.Size(130, 30);
            this.find_address.TabIndex = 28;
            this.find_address.Text = "Find_address";
            this.find_address.UseVisualStyleBackColor = true;
            this.find_address.Click += new System.EventHandler(this.find_address_Click);
            // 
            // Show_all
            // 
            this.Show_all.Location = new System.Drawing.Point(1064, 442);
            this.Show_all.Margin = new System.Windows.Forms.Padding(4);
            this.Show_all.Name = "Show_all";
            this.Show_all.Size = new System.Drawing.Size(138, 47);
            this.Show_all.TabIndex = 29;
            this.Show_all.Text = "Show_all";
            this.Show_all.UseVisualStyleBackColor = true;
            this.Show_all.Click += new System.EventHandler(this.Show_all_Click);
            // 
            // find_phone
            // 
            this.find_phone.Location = new System.Drawing.Point(842, 28);
            this.find_phone.Margin = new System.Windows.Forms.Padding(4);
            this.find_phone.Name = "find_phone";
            this.find_phone.Size = new System.Drawing.Size(130, 30);
            this.find_phone.TabIndex = 30;
            this.find_phone.Text = "Find_phone";
            this.find_phone.UseVisualStyleBackColor = true;
            this.find_phone.Click += new System.EventHandler(this.find_phone_Click);
            // 
            // find_device
            // 
            this.find_device.Location = new System.Drawing.Point(842, 76);
            this.find_device.Margin = new System.Windows.Forms.Padding(4);
            this.find_device.Name = "find_device";
            this.find_device.Size = new System.Drawing.Size(130, 30);
            this.find_device.TabIndex = 31;
            this.find_device.Text = "Find_device";
            this.find_device.UseVisualStyleBackColor = true;
            this.find_device.Click += new System.EventHandler(this.find_device_Click);
            // 
            // find_license
            // 
            this.find_license.Location = new System.Drawing.Point(842, 122);
            this.find_license.Margin = new System.Windows.Forms.Padding(4);
            this.find_license.Name = "find_license";
            this.find_license.Size = new System.Drawing.Size(130, 30);
            this.find_license.TabIndex = 32;
            this.find_license.Text = "Find_license";
            this.find_license.UseVisualStyleBackColor = true;
            this.find_license.Click += new System.EventHandler(this.find_license_Click);
            // 
            // find_line
            // 
            this.find_line.Location = new System.Drawing.Point(842, 163);
            this.find_line.Margin = new System.Windows.Forms.Padding(4);
            this.find_line.Name = "find_line";
            this.find_line.Size = new System.Drawing.Size(130, 30);
            this.find_line.TabIndex = 33;
            this.find_line.Text = "Find_line";
            this.find_line.UseVisualStyleBackColor = true;
            this.find_line.Click += new System.EventHandler(this.find_line_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1224, 651);
            this.Controls.Add(this.find_line);
            this.Controls.Add(this.find_license);
            this.Controls.Add(this.find_device);
            this.Controls.Add(this.find_phone);
            this.Controls.Add(this.Show_all);
            this.Controls.Add(this.find_address);
            this.Controls.Add(this.find_passport);
            this.Controls.Add(this.find_otch);
            this.Controls.Add(this.find_name);
            this.Controls.Add(this.find_surname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtOtch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAI Abonents";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtSurname;
        private DataGridView GridView;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtOtch;
        private TextBox txtPassport;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtDevice;
        private TextBox txtLicense;
        private TextBox txtTest;
        private PictureBox pictureBox1;
        private Button find_surname;
        private Button find_name;
        private Button find_otch;
        private Button find_passport;
        private Button find_address;
        private Button Show_all;
        private Button find_phone;
        private Button find_device;
        private Button find_license;
        private Button find_line;
    }
}