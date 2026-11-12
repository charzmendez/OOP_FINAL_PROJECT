namespace Mendez_Dinalo.UI
{
    partial class NETWORKDEVICESFORM
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
            lblNetworkdevices = new Label();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            lblDevice = new Label();
            lblDevicesno = new Label();
            lblWithip = new Label();
            lblWithipno = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNetworkdevices
            // 
            lblNetworkdevices.AutoSize = true;
            lblNetworkdevices.Location = new Point(73, 27);
            lblNetworkdevices.Name = "lblNetworkdevices";
            lblNetworkdevices.Size = new Size(152, 20);
            lblNetworkdevices.TabIndex = 0;
            lblNetworkdevices.Text = " NETWORK DEVICES  ";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(95, 77);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = " Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(586, 230);
            dataGridView1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(638, 432);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDevice
            // 
            lblDevice.AutoSize = true;
            lblDevice.Location = new Point(108, 381);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(63, 20);
            lblDevice.TabIndex = 4;
            lblDevice.Text = "Devices:";
            // 
            // lblDevicesno
            // 
            lblDevicesno.AutoSize = true;
            lblDevicesno.Location = new Point(175, 381);
            lblDevicesno.Name = "lblDevicesno";
            lblDevicesno.Size = new Size(17, 20);
            lblDevicesno.TabIndex = 5;
            lblDevicesno.Text = "0";
            // 
            // lblWithip
            // 
            lblWithip.AutoSize = true;
            lblWithip.Location = new Point(394, 381);
            lblWithip.Name = "lblWithip";
            lblWithip.Size = new Size(125, 20);
            lblWithip.TabIndex = 6;
            lblWithip.Text = " With IP assigned:";
            // 
            // lblWithipno
            // 
            lblWithipno.AutoSize = true;
            lblWithipno.Location = new Point(525, 381);
            lblWithipno.Name = "lblWithipno";
            lblWithipno.Size = new Size(17, 20);
            lblWithipno.TabIndex = 7;
            lblWithipno.Text = "0";
            // 
            // NETWORKDEVICESFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(lblWithipno);
            Controls.Add(lblWithip);
            Controls.Add(lblDevicesno);
            Controls.Add(lblDevice);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(lblNetworkdevices);
            Name = "NETWORKDEVICESFORM";
            Text = "NETWORKDEVICESFORM";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNetworkdevices;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Label lblDevice;
        private Label lblDevicesno;
        private Label lblWithip;
        private Label lblWithipno;
    }
}