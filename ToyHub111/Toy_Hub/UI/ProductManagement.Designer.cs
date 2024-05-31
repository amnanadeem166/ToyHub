using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class ProductManagement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addprod_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Price_lb = new System.Windows.Forms.Label();
            this.ProdNa_lb = new System.Windows.Forms.Label();
            this.ProdName_txt = new System.Windows.Forms.TextBox();
            this.Search_cbx = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 360);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 209);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.addprod_btn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.84615F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.15385F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(720, 209);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // addprod_btn
            // 
            this.addprod_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addprod_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addprod_btn.Location = new System.Drawing.Point(2, 177);
            this.addprod_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addprod_btn.Name = "addprod_btn";
            this.addprod_btn.Size = new System.Drawing.Size(716, 30);
            this.addprod_btn.TabIndex = 9;
            this.addprod_btn.Text = "Add Products";
            this.addprod_btn.UseVisualStyleBackColor = false;
            this.addprod_btn.Click += new System.EventHandler(this.addprod_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(716, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42105F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.57895F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Description_txt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Description_lbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Price_txt, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Price_lb, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProdNa_lb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProdName_txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Search_cbx, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(720, 92);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Description_txt
            // 
            this.Description_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_txt.Location = new System.Drawing.Point(170, 48);
            this.Description_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Description_txt.Multiline = true;
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(187, 42);
            this.Description_txt.TabIndex = 5;
            this.Description_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Description_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_lbl.Location = new System.Drawing.Point(2, 46);
            this.Description_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(164, 46);
            this.Description_lbl.TabIndex = 4;
            this.Description_lbl.Text = "Description";
            this.Description_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_txt
            // 
            this.Price_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price_txt.Location = new System.Drawing.Point(541, 2);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(177, 26);
            this.Price_txt.TabIndex = 3;
            this.Price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price_lb
            // 
            this.Price_lb.AutoSize = true;
            this.Price_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Price_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price_lb.Location = new System.Drawing.Point(361, 0);
            this.Price_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price_lb.Name = "Price_lb";
            this.Price_lb.Size = new System.Drawing.Size(176, 46);
            this.Price_lb.TabIndex = 2;
            this.Price_lb.Text = "Price";
            this.Price_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProdNa_lb
            // 
            this.ProdNa_lb.AutoSize = true;
            this.ProdNa_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProdNa_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdNa_lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProdNa_lb.Location = new System.Drawing.Point(2, 0);
            this.ProdNa_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProdNa_lb.Name = "ProdNa_lb";
            this.ProdNa_lb.Size = new System.Drawing.Size(164, 46);
            this.ProdNa_lb.TabIndex = 0;
            this.ProdNa_lb.Text = "Product Name";
            this.ProdNa_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProdName_txt
            // 
            this.ProdName_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdName_txt.Location = new System.Drawing.Point(170, 2);
            this.ProdName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ProdName_txt.Name = "ProdName_txt";
            this.ProdName_txt.Size = new System.Drawing.Size(187, 26);
            this.ProdName_txt.TabIndex = 1;
            this.ProdName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search_cbx
            // 
            this.Search_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_cbx.FormattingEnabled = true;
            this.Search_cbx.Location = new System.Drawing.Point(541, 48);
            this.Search_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Search_cbx.Name = "Search_cbx";
            this.Search_cbx.Size = new System.Drawing.Size(177, 28);
            this.Search_cbx.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(361, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.70389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.29611F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::Toy_Hub.Properties.Resources.BackArrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(633, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button1;
        private Label Description_lbl;
        private Label Price_lb;
        private Label ProdNa_lb;
        private TextBox ProdName_txt;
        private TextBox Description_txt;
        private Panel panel2;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button addprod_btn;
        private DataGridView dataGridView1;
        private TextBox Price_txt;
        private ComboBox Search_cbx;
    }
}