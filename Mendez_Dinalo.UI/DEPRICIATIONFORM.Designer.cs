namespace Mendez_Dinalo.UI
{
    partial class DEPRICIATIONFORM
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblDepreciation = new Label();
            lblFilter = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            lblTotalassets = new Label();
            lblTotalassetno = new Label();
            lblTotalannual = new Label();
            lblTotalannualdepreciationno = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDepreciation
            // 
            lblDepreciation.AutoSize = true;
            lblDepreciation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDepreciation.Location = new Point(116, 25);
            lblDepreciation.Name = "lblDepreciation";
            lblDepreciation.Size = new Size(210, 23);
            lblDepreciation.TabIndex = 0;
            lblDepreciation.Text = "DEPRECIATION REPORT";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(116, 84);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(45, 20);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Filter:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(549, 210);
            dataGridView1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(671, 405);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTotalassets
            // 
            lblTotalassets.AutoSize = true;
            lblTotalassets.Location = new Point(89, 356);
            lblTotalassets.Name = "lblTotalassets";
            lblTotalassets.Size = new Size(92, 20);
            lblTotalassets.TabIndex = 5;
            lblTotalassets.Text = " Total assets:";
            // 
            // lblTotalassetno
            // 
            lblTotalassetno.AutoSize = true;
            lblTotalassetno.Location = new Point(187, 356);
            lblTotalassetno.Name = "lblTotalassetno";
            lblTotalassetno.Size = new Size(17, 20);
            lblTotalassetno.TabIndex = 6;
            lblTotalassetno.Text = "0";
            // 
            // lblTotalannual
            // 
            lblTotalannual.AutoSize = true;
            lblTotalannual.Location = new Point(345, 356);
            lblTotalannual.Name = "lblTotalannual";
            lblTotalannual.Size = new Size(181, 20);
            lblTotalannual.TabIndex = 7;
            lblTotalannual.Text = "Total annual depreciation:";
            // 
            // lblTotalannualdepreciationno
            // 
            lblTotalannualdepreciationno.AutoSize = true;
            lblTotalannualdepreciationno.Location = new Point(532, 356);
            lblTotalannualdepreciationno.Name = "lblTotalannualdepreciationno";
            lblTotalannualdepreciationno.Size = new Size(17, 20);
            lblTotalannualdepreciationno.TabIndex = 8;
            lblTotalannualdepreciationno.Text = "0";
            // 
            // DEPRICIATIONFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalannualdepreciationno);
            Controls.Add(lblTotalannual);
            Controls.Add(lblTotalassetno);
            Controls.Add(lblTotalassets);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(lblFilter);
            Controls.Add(lblDepreciation);
            Name = "DEPRICIATIONFORM";
            Text = "DEPRICIATIONFORM";
            Load += DEPRICIATIONFORM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDepreciation;
        private Label lblFilter;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Label lblTotalassets;
        private Label lblTotalassetno;
        private Label lblTotalannual;
        private Label lblTotalannualdepreciationno;
    }
}