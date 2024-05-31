using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class UpdateStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.joiningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.statusCmb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.typeCmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 456);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.updateBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 424);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(785, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateBtn.Location = new System.Drawing.Point(2, 2);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(781, 28);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 417);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLayoutPanel3.Controls.Add(this.joiningDateTimePicker, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.statusCmb, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.typeCmb, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtQualification, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtAddress, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtContactNumber, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtLastName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.idTxt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dobDateTimePicker, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.genderCmb, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 12);
            this.tableLayoutPanel3.Controls.Add(this.Password_txt, 1, 12);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(156, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 13;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.675438F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.456141F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.991228F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.210526F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(504, 366);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // joiningDateTimePicker
            // 
            this.joiningDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joiningDateTimePicker.Location = new System.Drawing.Point(149, 296);
            this.joiningDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.joiningDateTimePicker.Name = "joiningDateTimePicker";
            this.joiningDateTimePicker.Size = new System.Drawing.Size(353, 26);
            this.joiningDateTimePicker.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(2, 294);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "Joining Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusCmb
            // 
            this.statusCmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusCmb.FormattingEnabled = true;
            this.statusCmb.Location = new System.Drawing.Point(149, 267);
            this.statusCmb.Margin = new System.Windows.Forms.Padding(2);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(353, 28);
            this.statusCmb.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(2, 265);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeCmb
            // 
            this.typeCmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCmb.FormattingEnabled = true;
            this.typeCmb.Location = new System.Drawing.Point(149, 243);
            this.typeCmb.Margin = new System.Windows.Forms.Padding(2);
            this.typeCmb.Name = "typeCmb";
            this.typeCmb.Size = new System.Drawing.Size(353, 28);
            this.typeCmb.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gender";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(2, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date of Birth ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQualification
            // 
            this.txtQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQualification.Location = new System.Drawing.Point(149, 164);
            this.txtQualification.Margin = new System.Windows.Forms.Padding(2);
            this.txtQualification.Multiline = true;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(353, 23);
            this.txtQualification.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Qualification";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(149, 137);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(353, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContactNumber.Location = new System.Drawing.Point(149, 110);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(353, 26);
            this.txtContactNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(149, 83);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(149, 56);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(353, 26);
            this.txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(149, 29);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(353, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTxt
            // 
            this.idTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTxt.Location = new System.Drawing.Point(149, 2);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(353, 26);
            this.idTxt.TabIndex = 1;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dobDateTimePicker.Location = new System.Drawing.Point(149, 191);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(353, 26);
            this.dobDateTimePicker.TabIndex = 15;
            // 
            // genderCmb
            // 
            this.genderCmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Location = new System.Drawing.Point(149, 218);
            this.genderCmb.Margin = new System.Windows.Forms.Padding(2);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(353, 28);
            this.genderCmb.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(2, 324);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 42);
            this.label14.TabIndex = 24;
            this.label14.Text = "Password";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_txt
            // 
            this.Password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password_txt.Location = new System.Drawing.Point(149, 326);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(353, 26);
            this.Password_txt.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.90932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.09068F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Staff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Toy_Hub.Properties.Resources.barrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(692, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateStaff";
            this.Text = "UpdateStaff";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private TextBox txtQualification;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtContactNumber;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private TextBox idTxt;
        private Button updateBtn;
        private DateTimePicker joiningDateTimePicker;
        private Label label13;
        private ComboBox statusCmb;
        private Label label12;
        private ComboBox typeCmb;
        private Label label11;
        private Label label10;
        private DateTimePicker dobDateTimePicker;
        private ComboBox genderCmb;
        private Label label14;
        private TextBox Password_txt;
    }
}