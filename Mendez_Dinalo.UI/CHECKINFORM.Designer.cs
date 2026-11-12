namespace Mendez_Dinalo.UI
{
    partial class CHECKINFORM
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
            lblCheckin = new Label();
            lblCurrently = new Label();
            btnCheckin = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            lblSelected = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCheckin
            // 
            lblCheckin.AutoSize = true;
            lblCheckin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCheckin.Location = new Point(60, 24);
            lblCheckin.Name = "lblCheckin";
            lblCheckin.Size = new Size(158, 23);
            lblCheckin.TabIndex = 0;
            lblCheckin.Text = "CHECK IN ASSET";
            // 
            // lblCurrently
            // 
            lblCurrently.AutoSize = true;
            lblCurrently.Location = new Point(75, 94);
            lblCurrently.Name = "lblCurrently";
            lblCurrently.Size = new Size(176, 20);
            lblCurrently.TabIndex = 1;
            lblCurrently.Text = "─ Currently checked out ─";
            // 
            // btnCheckin
            // 
            btnCheckin.Location = new Point(563, 397);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Size = new Size(94, 29);
            btnCheckin.TabIndex = 2;
            btnCheckin.Text = "Check In";
            btnCheckin.UseVisualStyleBackColor = true;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(663, 397);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(509, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(122, 344);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(95, 20);
            lblSelected.TabIndex = 5;
            lblSelected.Text = "Selected tag:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 344);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // CHECKINFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(lblSelected);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnCheckin);
            Controls.Add(lblCurrently);
            Controls.Add(lblCheckin);
            Name = "CHECKINFORM";
            Text = "CHECKINFORM";
            Load += CHECKINFORM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCheckin;
        private Label lblCurrently;
        private Button btnCheckin;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Label lblSelected;
        private ComboBox comboBox1;
    }
}