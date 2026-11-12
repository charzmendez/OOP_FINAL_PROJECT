namespace Mendez_Dinalo.UI
{
    partial class ADDASSETFORM
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
            comboBox1 = new ComboBox();
            lblAssesttype = new Label();
            textBox1 = new TextBox();
            lblAssettag = new Label();
            textBox2 = new TextBox();
            lblName = new Label();
            numericUpDown1 = new NumericUpDown();
            lblPurchase = new Label();
            lblCPU = new Label();
            textBox3 = new TextBox();
            lblIP = new Label();
            lblMAC = new Label();
            lblMonths = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblAssesttype
            // 
            lblAssesttype.AutoSize = true;
            lblAssesttype.Location = new Point(258, 83);
            lblAssesttype.Name = "lblAssesttype";
            lblAssesttype.Size = new Size(75, 20);
            lblAssesttype.TabIndex = 1;
            lblAssesttype.Text = "AssetType";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 2;
            // 
            // lblAssettag
            // 
            lblAssettag.AutoSize = true;
            lblAssettag.Location = new Point(450, 84);
            lblAssettag.Name = "lblAssettag";
            lblAssettag.Size = new Size(71, 20);
            lblAssettag.TabIndex = 3;
            lblAssettag.Text = "Asset Tag";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(123, 204);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(232, 252);
            numericUpDown1.Maximum = 1000000M;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // lblPurchase
            // 
            lblPurchase.AutoSize = true;
            lblPurchase.Location = new Point(123, 254);
            lblPurchase.Name = "lblPurchase";
            lblPurchase.Size = new Size(106, 20);
            lblPurchase.TabIndex = 7;
            lblPurchase.Text = "Purchase Price:";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(187, 304);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(39, 20);
            lblCPU.TabIndex = 9;
            lblCPU.Text = "CPU:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(145, 346);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(81, 20);
            lblIP.TabIndex = 11;
            lblIP.Text = "IP Address:";
            // 
            // lblMAC
            // 
            lblMAC.AutoSize = true;
            lblMAC.Location = new Point(125, 391);
            lblMAC.Name = "lblMAC";
            lblMAC.Size = new Size(101, 20);
            lblMAC.TabIndex = 12;
            lblMAC.Text = "MAC Address:";
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Location = new Point(90, 436);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(136, 20);
            lblMonths.TabIndex = 13;
            lblMonths.Text = "Months Remaining:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(232, 342);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(232, 388);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(232, 436);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(309, 23);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 17;
            label1.Text = "ADD ASSET FORM";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(541, 508);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(663, 508);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ADDASSETFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 579);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(lblMonths);
            Controls.Add(lblMAC);
            Controls.Add(lblIP);
            Controls.Add(textBox3);
            Controls.Add(lblCPU);
            Controls.Add(lblPurchase);
            Controls.Add(numericUpDown1);
            Controls.Add(lblName);
            Controls.Add(textBox2);
            Controls.Add(lblAssettag);
            Controls.Add(textBox1);
            Controls.Add(lblAssesttype);
            Controls.Add(comboBox1);
            Name = "ADDASSETFORM";
            Text = "ADDASSETFORM";
            Load += ADDASSETFORM_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblAssesttype;
        private TextBox textBox1;
        private Label lblAssettag;
        private TextBox textBox2;
        private Label lblName;
        private NumericUpDown numericUpDown1;
        private Label lblPurchase;
        private Label lblCPU;
        private TextBox textBox3;
        private Label lblIP;
        private Label lblMAC;
        private Label lblMonths;
        private TextBox textBox4;
        private TextBox textBox5;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Button btnAdd;
        private Button btnCancel;
    }
}