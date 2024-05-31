using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class StaffManagement
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.staff_dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.search_cbx = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.joini_dtp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.type_cbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salary_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lname_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.gen_cbx = new System.Windows.Forms.ComboBox();
            this.dob_dtp = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.qualification = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backarrow_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_dgv)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 598);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.staff_dgv, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 191);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1100, 407);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // staff_dgv
            // 
            this.staff_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.staff_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staff_dgv.Location = new System.Drawing.Point(2, 2);
            this.staff_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.staff_dgv.Name = "staff_dgv";
            this.staff_dgv.RowHeadersWidth = 62;
            this.staff_dgv.Size = new System.Drawing.Size(1096, 403);
            this.staff_dgv.TabIndex = 0;
            this.staff_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staff_dgv_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.splitter5, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.splitter4, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.search_cbx, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.search_btn, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.splitter3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.joini_dtp, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.type_cbx, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.salary_txt, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.contact_txt, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.address_txt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.email_txt, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lname_tx, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Fname_txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gen_cbx, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dob_dtp, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.add_btn, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.qualification, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.password_txt, 5, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1100, 145);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(917, 115);
            this.splitter5.Margin = new System.Windows.Forms.Padding(2);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(114, 28);
            this.splitter5.TabIndex = 29;
            this.splitter5.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(734, 115);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(114, 28);
            this.splitter4.TabIndex = 28;
            this.splitter4.TabStop = false;
            // 
            // search_cbx
            // 
            this.search_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_cbx.FormattingEnabled = true;
            this.search_cbx.Location = new System.Drawing.Point(551, 115);
            this.search_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.search_cbx.Name = "search_cbx";
            this.search_cbx.Size = new System.Drawing.Size(179, 28);
            this.search_cbx.TabIndex = 27;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.LightBlue;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_btn.Location = new System.Drawing.Point(368, 115);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(179, 28);
            this.search_btn.TabIndex = 26;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(2, 115);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(114, 28);
            this.splitter3.TabIndex = 25;
            this.splitter3.TabStop = false;
            // 
            // joini_dtp
            // 
            this.joini_dtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joini_dtp.Location = new System.Drawing.Point(551, 87);
            this.joini_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.joini_dtp.Name = "joini_dtp";
            this.joini_dtp.Size = new System.Drawing.Size(179, 26);
            this.joini_dtp.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(368, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Joining Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date of Birth";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(734, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Qualification";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_cbx
            // 
            this.type_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_cbx.FormattingEnabled = true;
            this.type_cbx.Location = new System.Drawing.Point(551, 59);
            this.type_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.type_cbx.Name = "type_cbx";
            this.type_cbx.Size = new System.Drawing.Size(179, 28);
            this.type_cbx.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(368, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salary_txt
            // 
            this.salary_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salary_txt.Location = new System.Drawing.Point(917, 31);
            this.salary_txt.Margin = new System.Windows.Forms.Padding(2);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(181, 26);
            this.salary_txt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(734, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_txt
            // 
            this.contact_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact_txt.Location = new System.Drawing.Point(551, 31);
            this.contact_txt.Margin = new System.Windows.Forms.Padding(2);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.Size = new System.Drawing.Size(179, 26);
            this.contact_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(368, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_txt
            // 
            this.address_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_txt.Location = new System.Drawing.Point(185, 31);
            this.address_txt.Margin = new System.Windows.Forms.Padding(2);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(179, 24);
            this.address_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_txt
            // 
            this.email_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_txt.Location = new System.Drawing.Point(917, 2);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(181, 26);
            this.email_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(734, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lname_tx
            // 
            this.Lname_tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lname_tx.Location = new System.Drawing.Point(551, 2);
            this.Lname_tx.Margin = new System.Windows.Forms.Padding(2);
            this.Lname_tx.Name = "Lname_tx";
            this.Lname_tx.Size = new System.Drawing.Size(179, 26);
            this.Lname_tx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(368, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
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
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fname_txt
            // 
            this.Fname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fname_txt.Location = new System.Drawing.Point(185, 2);
            this.Fname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(179, 26);
            this.Fname_txt.TabIndex = 1;
            // 
            // gen_cbx
            // 
            this.gen_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gen_cbx.FormattingEnabled = true;
            this.gen_cbx.Location = new System.Drawing.Point(185, 59);
            this.gen_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.gen_cbx.Name = "gen_cbx";
            this.gen_cbx.Size = new System.Drawing.Size(179, 28);
            this.gen_cbx.TabIndex = 13;
            // 
            // dob_dtp
            // 
            this.dob_dtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dob_dtp.Location = new System.Drawing.Point(185, 87);
            this.dob_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dob_dtp.Name = "dob_dtp";
            this.dob_dtp.Size = new System.Drawing.Size(179, 26);
            this.dob_dtp.TabIndex = 19;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightBlue;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.Location = new System.Drawing.Point(185, 115);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(179, 28);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // qualification
            // 
            this.qualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualification.Location = new System.Drawing.Point(917, 59);
            this.qualification.Margin = new System.Windows.Forms.Padding(2);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(181, 26);
            this.qualification.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(734, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "Password";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Location = new System.Drawing.Point(917, 87);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(181, 26);
            this.password_txt.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.625F));
            this.tableLayoutPanel1.Controls.Add(this.backarrow_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // backarrow_btn
            // 
            this.backarrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backarrow_btn.BackgroundImage = global::Toy_Hub.Properties.Resources.barrow;
            this.backarrow_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backarrow_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backarrow_btn.Location = new System.Drawing.Point(985, 2);
            this.backarrow_btn.Margin = new System.Windows.Forms.Padding(2);
            this.backarrow_btn.Name = "backarrow_btn";
            this.backarrow_btn.Size = new System.Drawing.Size(113, 42);
            this.backarrow_btn.TabIndex = 2;
            this.backarrow_btn.UseVisualStyleBackColor = false;
            this.backarrow_btn.Click += new System.EventHandler(this.backarrow_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(979, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Staff Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1100, 598);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staff_dgv)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button backarrow_btn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label11;
        private Label label10;
        private ComboBox type_cbx;
        private Label label9;
        private Label label8;
        private TextBox salary_txt;
        private Label label7;
        private TextBox contact_txt;
        private Label label6;
        private TextBox address_txt;
        private Label label5;
        private TextBox email_txt;
        private Label label4;
        private TextBox Lname_tx;
        private Label label3;
        private Label label2;
        private TextBox Fname_txt;
        private ComboBox gen_cbx;
        private DateTimePicker dob_dtp;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView staff_dgv;
        private Splitter splitter5;
        private Splitter splitter4;
        private ComboBox search_cbx;
        private Button search_btn;
        private Splitter splitter3;
        private DateTimePicker joini_dtp;
        private Label label12;
        private Button add_btn;
        private TextBox qualification;
        private Label label13;
        private TextBox password_txt;
    }
}