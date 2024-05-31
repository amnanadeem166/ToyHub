using System.Drawing;
using System.Windows.Forms;

namespace ToyHub.UI
{
    partial class UpdateSalary
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGrid = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGrid, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 176);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(877, 301);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = Color.FromArgb(255, 255, 198);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(3, 3);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.Size = new Size(871, 295);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(255, 255, 128);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Location = new Point(37, 54);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(871, 78);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(690, 78);
            label1.TabIndex = 0;
            label1.Text = "Decide Staff Member Salary";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.BackgroundImage = Toy_Hub.Properties.Resources.barrow;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(699, 3);
            button1.Name = "button1";
            button1.Size = new Size(169, 72);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpdateSalary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(969, 523);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateSalary";
            Text = "DecideSalary";
            Load += UpdateSalary_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGrid;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button button1;
    }
}