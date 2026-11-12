namespace Mendez_Dinalo.UI
{
    partial class CHECKOUTFORM
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
            lblCheck = new Label();
            textBox1 = new TextBox();
            lblAssettag = new Label();
            btnFind = new Button();
            lblAssetdetails = new Label();
            lblName = new Label();
            lblType = new Label();
            lblStatus = new Label();
            lblBorrowable = new Label();
            btnCheckout = new Button();
            btnClose = new Button();
            textBox2 = new TextBox();
            lblStudent = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // lblCheck
            // 
            lblCheck.AutoSize = true;
            lblCheck.Location = new Point(60, 9);
            lblCheck.Name = "lblCheck";
            lblCheck.Size = new Size(142, 20);
            lblCheck.TabIndex = 0;
            lblCheck.Text = "CHECK OUT ASSET  ";
            lblCheck.Click += lblCheck_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 1;
            // 
            // lblAssettag
            // 
            lblAssettag.AutoSize = true;
            lblAssettag.Location = new Point(109, 82);
            lblAssettag.Name = "lblAssettag";
            lblAssettag.Size = new Size(78, 20);
            lblAssettag.TabIndex = 2;
            lblAssettag.Text = "Asset Tag: ";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(365, 79);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 3;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // lblAssetdetails
            // 
            lblAssetdetails.AutoSize = true;
            lblAssetdetails.Location = new Point(125, 168);
            lblAssetdetails.Name = "lblAssetdetails";
            lblAssetdetails.Size = new Size(116, 20);
            lblAssetdetails.TabIndex = 4;
            lblAssetdetails.Text = "─ Asset details ─";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(166, 204);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(174, 233);
            lblType.Name = "lblType";
            lblType.Size = new Size(51, 20);
            lblType.TabIndex = 6;
            lblType.Text = "Type:  ";
            lblType.Click += lblType_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(166, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:  ";
            // 
            // lblBorrowable
            // 
            lblBorrowable.AutoSize = true;
            lblBorrowable.Location = new Point(125, 304);
            lblBorrowable.Name = "lblBorrowable";
            lblBorrowable.Size = new Size(93, 20);
            lblBorrowable.TabIndex = 8;
            lblBorrowable.Text = " Borrowable:";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(541, 398);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = " Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(664, 398);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close ";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(132, 362);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(86, 20);
            lblStudent.TabIndex = 13;
            lblStudent.Text = " Student ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(224, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(224, 267);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(224, 301);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 17;
            // 
            // CHECKOUTFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblStudent);
            Controls.Add(textBox2);
            Controls.Add(btnClose);
            Controls.Add(btnCheckout);
            Controls.Add(lblBorrowable);
            Controls.Add(lblStatus);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Controls.Add(lblAssetdetails);
            Controls.Add(btnFind);
            Controls.Add(lblAssettag);
            Controls.Add(textBox1);
            Controls.Add(lblCheck);
            Name = "CHECKOUTFORM";
            Text = "CHECKOUTFORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCheck;
        private TextBox textBox1;
        private Label lblAssettag;
        private Button btnFind;
        private Label lblAssetdetails;
        private Label lblName;
        private Label lblType;
        private Label lblStatus;
        private Label lblBorrowable;
        private Button btnCheckout;
        private Button btnClose;
        private TextBox textBox2;
        private Label lblStudent;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}