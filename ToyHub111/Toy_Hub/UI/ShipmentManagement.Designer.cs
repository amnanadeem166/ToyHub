using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class ShipmentManagement
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dob_lbl = new System.Windows.Forms.Label();
            this.cpcontact_txt = new System.Windows.Forms.TextBox();
            this.compcontt_lbl = new System.Windows.Forms.Label();
            this.cpadd_txt = new System.Windows.Forms.TextBox();
            this.compadd_lbl = new System.Windows.Forms.Label();
            this.Cpname_txt = new System.Windows.Forms.TextBox();
            this.comName_lbl = new System.Windows.Forms.Label();
            this.gend_lbl = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.addres_lbl = new System.Windows.Forms.Label();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.conta_lbl = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.Lname_txt = new System.Windows.Forms.TextBox();
            this.Lname_lbl = new System.Windows.Forms.Label();
            this.Fname_lbl = new System.Windows.Forms.Label();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.gender_cbx = new System.Windows.Forms.ComboBox();
            this.dob_dtp = new System.Windows.Forms.DateTimePicker();
            this.joiningDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.backarrow_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1493, 521);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGrid, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.add_btn, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 227);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.31468F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.68532F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1493, 294);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(2, 2);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(1489, 246);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightBlue;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(2, 252);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(1489, 40);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.44498F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14752F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1705F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.71947F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43531F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dob_lbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cpcontact_txt, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.compcontt_lbl, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.cpadd_txt, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.compadd_lbl, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Cpname_txt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comName_lbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gend_lbl, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.address_txt, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.addres_lbl, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.contact_txt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.conta_lbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.email_txt, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.email_lbl, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lname_txt, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lname_lbl, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Fname_lbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fname_txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gender_cbx, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.dob_dtp, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.joiningDate, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.password_txt, 5, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.13821F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1493, 169);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(487, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 65);
            this.label2.TabIndex = 24;
            this.label2.Text = "Joining Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dob_lbl
            // 
            this.dob_lbl.AutoSize = true;
            this.dob_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.dob_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dob_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dob_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dob_lbl.Location = new System.Drawing.Point(2, 104);
            this.dob_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dob_lbl.Name = "dob_lbl";
            this.dob_lbl.Size = new System.Drawing.Size(236, 65);
            this.dob_lbl.TabIndex = 18;
            this.dob_lbl.Text = "Date of Birth";
            this.dob_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpcontact_txt
            // 
            this.cpcontact_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpcontact_txt.Location = new System.Drawing.Point(1188, 61);
            this.cpcontact_txt.Margin = new System.Windows.Forms.Padding(2);
            this.cpcontact_txt.Name = "cpcontact_txt";
            this.cpcontact_txt.Size = new System.Drawing.Size(303, 26);
            this.cpcontact_txt.TabIndex = 17;
            // 
            // compcontt_lbl
            // 
            this.compcontt_lbl.AutoSize = true;
            this.compcontt_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.compcontt_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compcontt_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.compcontt_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.compcontt_lbl.Location = new System.Drawing.Point(954, 59);
            this.compcontt_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compcontt_lbl.Name = "compcontt_lbl";
            this.compcontt_lbl.Size = new System.Drawing.Size(230, 45);
            this.compcontt_lbl.TabIndex = 16;
            this.compcontt_lbl.Text = "Company Contact";
            this.compcontt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpadd_txt
            // 
            this.cpadd_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpadd_txt.Location = new System.Drawing.Point(698, 61);
            this.cpadd_txt.Margin = new System.Windows.Forms.Padding(2);
            this.cpadd_txt.Multiline = true;
            this.cpadd_txt.Name = "cpadd_txt";
            this.cpadd_txt.Size = new System.Drawing.Size(252, 41);
            this.cpadd_txt.TabIndex = 15;
            // 
            // compadd_lbl
            // 
            this.compadd_lbl.AutoSize = true;
            this.compadd_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.compadd_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compadd_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.compadd_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.compadd_lbl.Location = new System.Drawing.Point(487, 59);
            this.compadd_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compadd_lbl.Name = "compadd_lbl";
            this.compadd_lbl.Size = new System.Drawing.Size(207, 45);
            this.compadd_lbl.TabIndex = 14;
            this.compadd_lbl.Text = "Company Address";
            this.compadd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cpname_txt
            // 
            this.Cpname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cpname_txt.Location = new System.Drawing.Point(242, 61);
            this.Cpname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Cpname_txt.Name = "Cpname_txt";
            this.Cpname_txt.Size = new System.Drawing.Size(241, 26);
            this.Cpname_txt.TabIndex = 13;
            // 
            // comName_lbl
            // 
            this.comName_lbl.AutoSize = true;
            this.comName_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.comName_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comName_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.comName_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comName_lbl.Location = new System.Drawing.Point(2, 59);
            this.comName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comName_lbl.Name = "comName_lbl";
            this.comName_lbl.Size = new System.Drawing.Size(236, 45);
            this.comName_lbl.TabIndex = 12;
            this.comName_lbl.Text = "Company Name";
            this.comName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gend_lbl
            // 
            this.gend_lbl.AutoSize = true;
            this.gend_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.gend_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gend_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gend_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gend_lbl.Location = new System.Drawing.Point(954, 29);
            this.gend_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gend_lbl.Name = "gend_lbl";
            this.gend_lbl.Size = new System.Drawing.Size(230, 30);
            this.gend_lbl.TabIndex = 10;
            this.gend_lbl.Text = "Gender";
            this.gend_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_txt
            // 
            this.address_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_txt.Location = new System.Drawing.Point(698, 31);
            this.address_txt.Margin = new System.Windows.Forms.Padding(2);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(252, 26);
            this.address_txt.TabIndex = 9;
            // 
            // addres_lbl
            // 
            this.addres_lbl.AutoSize = true;
            this.addres_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.addres_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addres_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addres_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addres_lbl.Location = new System.Drawing.Point(487, 29);
            this.addres_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addres_lbl.Name = "addres_lbl";
            this.addres_lbl.Size = new System.Drawing.Size(207, 30);
            this.addres_lbl.TabIndex = 8;
            this.addres_lbl.Text = "Address";
            this.addres_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_txt
            // 
            this.contact_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact_txt.Location = new System.Drawing.Point(242, 31);
            this.contact_txt.Margin = new System.Windows.Forms.Padding(2);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.Size = new System.Drawing.Size(241, 26);
            this.contact_txt.TabIndex = 7;
            // 
            // conta_lbl
            // 
            this.conta_lbl.AutoSize = true;
            this.conta_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.conta_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conta_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.conta_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conta_lbl.Location = new System.Drawing.Point(2, 29);
            this.conta_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conta_lbl.Name = "conta_lbl";
            this.conta_lbl.Size = new System.Drawing.Size(236, 30);
            this.conta_lbl.TabIndex = 6;
            this.conta_lbl.Text = "Contact";
            this.conta_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_txt
            // 
            this.email_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_txt.Location = new System.Drawing.Point(1188, 2);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(303, 26);
            this.email_txt.TabIndex = 5;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.email_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.email_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_lbl.Location = new System.Drawing.Point(954, 0);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(230, 29);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "Email";
            this.email_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lname_txt
            // 
            this.Lname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lname_txt.Location = new System.Drawing.Point(698, 2);
            this.Lname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Lname_txt.Name = "Lname_txt";
            this.Lname_txt.Size = new System.Drawing.Size(252, 26);
            this.Lname_txt.TabIndex = 3;
            // 
            // Lname_lbl
            // 
            this.Lname_lbl.AutoSize = true;
            this.Lname_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.Lname_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lname_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Lname_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lname_lbl.Location = new System.Drawing.Point(487, 0);
            this.Lname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lname_lbl.Name = "Lname_lbl";
            this.Lname_lbl.Size = new System.Drawing.Size(207, 29);
            this.Lname_lbl.TabIndex = 2;
            this.Lname_lbl.Text = " Last Name";
            this.Lname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fname_lbl
            // 
            this.Fname_lbl.AutoSize = true;
            this.Fname_lbl.BackColor = System.Drawing.Color.LightBlue;
            this.Fname_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fname_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname_lbl.Location = new System.Drawing.Point(2, 0);
            this.Fname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fname_lbl.Name = "Fname_lbl";
            this.Fname_lbl.Size = new System.Drawing.Size(236, 29);
            this.Fname_lbl.TabIndex = 0;
            this.Fname_lbl.Text = "First Name";
            this.Fname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fname_txt
            // 
            this.fname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fname_txt.Location = new System.Drawing.Point(242, 2);
            this.fname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(241, 26);
            this.fname_txt.TabIndex = 1;
            // 
            // gender_cbx
            // 
            this.gender_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_cbx.FormattingEnabled = true;
            this.gender_cbx.Location = new System.Drawing.Point(1188, 31);
            this.gender_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.gender_cbx.Name = "gender_cbx";
            this.gender_cbx.Size = new System.Drawing.Size(303, 28);
            this.gender_cbx.TabIndex = 11;
            // 
            // dob_dtp
            // 
            this.dob_dtp.Location = new System.Drawing.Point(242, 106);
            this.dob_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dob_dtp.Name = "dob_dtp";
            this.dob_dtp.Size = new System.Drawing.Size(119, 26);
            this.dob_dtp.TabIndex = 19;
            // 
            // joiningDate
            // 
            this.joiningDate.Location = new System.Drawing.Point(698, 106);
            this.joiningDate.Margin = new System.Windows.Forms.Padding(2);
            this.joiningDate.Name = "joiningDate";
            this.joiningDate.Size = new System.Drawing.Size(123, 26);
            this.joiningDate.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(954, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 65);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Location = new System.Drawing.Point(1188, 106);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(303, 26);
            this.password_txt.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.61327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.386733F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backarrow_btn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1493, 58);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(1348, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Shipment Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backarrow_btn
            // 
            this.backarrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backarrow_btn.BackgroundImage = global::Toy_Hub.Properties.Resources.barrow;
            this.backarrow_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backarrow_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backarrow_btn.Location = new System.Drawing.Point(1354, 2);
            this.backarrow_btn.Margin = new System.Windows.Forms.Padding(2);
            this.backarrow_btn.Name = "backarrow_btn";
            this.backarrow_btn.Size = new System.Drawing.Size(137, 54);
            this.backarrow_btn.TabIndex = 1;
            this.backarrow_btn.UseVisualStyleBackColor = false;
            this.backarrow_btn.Click += new System.EventHandler(this.backarrow_btn_Click);
            // 
            // ShipmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1493, 521);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1515, 577);
            this.Name = "ShipmentManagement";
            this.Text = "ShipmentManagement";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label Fname_lbl;
        private Label gend_lbl;
        private TextBox address_txt;
        private Label addres_lbl;
        private TextBox contact_txt;
        private Label conta_lbl;
        private TextBox email_txt;
        private Label email_lbl;
        private TextBox Lname_txt;
        private Label Lname_lbl;
        private TextBox fname_txt;
        private ComboBox gender_cbx;
        private Button add_btn;
        private Label dob_lbl;
        private TextBox cpcontact_txt;
        private Label compcontt_lbl;
        private TextBox cpadd_txt;
        private Label compadd_lbl;
        private TextBox Cpname_txt;
        private Label comName_lbl;
        private DateTimePicker dob_dtp;
        private Button backarrow_btn;
        private Label label2;
        private DateTimePicker joiningDate;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGrid;
        private TextBox password_txt;
        private Label label3;
    }
}