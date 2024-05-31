using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class ReportsPage
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.staff_btn = new System.Windows.Forms.Button();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.Profit_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.backarrow_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 292);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.staff_btn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.purchase_btn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Profit_btn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(116, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 238);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // staff_btn
            // 
            this.staff_btn.BackColor = System.Drawing.Color.LightBlue;
            this.staff_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staff_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.staff_btn.Location = new System.Drawing.Point(2, 160);
            this.staff_btn.Margin = new System.Windows.Forms.Padding(2);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(527, 76);
            this.staff_btn.TabIndex = 2;
            this.staff_btn.Text = "Profit Report";
            this.staff_btn.UseVisualStyleBackColor = false;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // purchase_btn
            // 
            this.purchase_btn.BackColor = System.Drawing.Color.LightBlue;
            this.purchase_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchase_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.purchase_btn.Location = new System.Drawing.Point(2, 81);
            this.purchase_btn.Margin = new System.Windows.Forms.Padding(2);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(527, 75);
            this.purchase_btn.TabIndex = 1;
            this.purchase_btn.Text = "Sales Order Report";
            this.purchase_btn.UseVisualStyleBackColor = false;
            this.purchase_btn.Click += new System.EventHandler(this.purchase_btn_Click);
            // 
            // Profit_btn
            // 
            this.Profit_btn.BackColor = System.Drawing.Color.LightBlue;
            this.Profit_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_btn.Location = new System.Drawing.Point(2, 2);
            this.Profit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Profit_btn.Name = "Profit_btn";
            this.Profit_btn.Size = new System.Drawing.Size(527, 75);
            this.Profit_btn.TabIndex = 0;
            this.Profit_btn.Text = "Total Overtime Hours";
            this.Profit_btn.UseVisualStyleBackColor = false;
            this.Profit_btn.Click += new System.EventHandler(this.Profit_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Linen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.375F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backarrow_btn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backarrow_btn
            // 
            this.backarrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backarrow_btn.BackgroundImage = global::Toy_Hub.Properties.Resources.BackArrow;
            this.backarrow_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backarrow_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backarrow_btn.ForeColor = System.Drawing.Color.Chocolate;
            this.backarrow_btn.Location = new System.Drawing.Point(632, 2);
            this.backarrow_btn.Margin = new System.Windows.Forms.Padding(2);
            this.backarrow_btn.Name = "backarrow_btn";
            this.backarrow_btn.Size = new System.Drawing.Size(86, 64);
            this.backarrow_btn.TabIndex = 1;
            this.backarrow_btn.UseVisualStyleBackColor = false;
            this.backarrow_btn.Click += new System.EventHandler(this.backarrow_btn_Click);
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsPage";
            this.Text = "ReportsPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button backarrow_btn;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button staff_btn;
        private Button purchase_btn;
        private Button Profit_btn;
    }
}