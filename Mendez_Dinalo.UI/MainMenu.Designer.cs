namespace Mendez_Dinalo.UI
{
    partial class MainMenu
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
            btnAdd = new Button();
            lblMAIN = new Label();
            btnView = new Button();
            btnCheckout = new Button();
            btnCheckin = new Button();
            btnDepreciation = new Button();
            btnDevice = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 52);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD ASSET";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // lblMAIN
            // 
            lblMAIN.AutoSize = true;
            lblMAIN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMAIN.Location = new Point(315, 19);
            lblMAIN.Name = "lblMAIN";
            lblMAIN.Size = new Size(152, 31);
            lblMAIN.TabIndex = 1;
            lblMAIN.Text = "MAIN MENU";
            // 
            // btnView
            // 
            btnView.Location = new Point(66, 134);
            btnView.Name = "btnView";
            btnView.Size = new Size(142, 52);
            btnView.TabIndex = 2;
            btnView.Text = "VIEW ALL ASSETS";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(66, 210);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(142, 52);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "CHECK OUT";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCheckin
            // 
            btnCheckin.Location = new Point(66, 289);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Size = new Size(142, 52);
            btnCheckin.TabIndex = 4;
            btnCheckin.Text = "CHECK IN";
            btnCheckin.UseVisualStyleBackColor = true;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // btnDepreciation
            // 
            btnDepreciation.Location = new Point(66, 364);
            btnDepreciation.Name = "btnDepreciation";
            btnDepreciation.Size = new Size(142, 52);
            btnDepreciation.TabIndex = 5;
            btnDepreciation.Text = "DEPRECIATION";
            btnDepreciation.UseVisualStyleBackColor = true;
            btnDepreciation.Click += btnDepreciation_Click;
            // 
            // btnDevice
            // 
            btnDevice.Location = new Point(66, 441);
            btnDevice.Name = "btnDevice";
            btnDevice.Size = new Size(142, 52);
            btnDevice.TabIndex = 6;
            btnDevice.Text = "NETWORK DEVICES";
            btnDevice.UseVisualStyleBackColor = true;
            btnDevice.Click += btnDevice_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(btnDevice);
            Controls.Add(btnDepreciation);
            Controls.Add(btnCheckin);
            Controls.Add(btnCheckout);
            Controls.Add(btnView);
            Controls.Add(lblMAIN);
            Controls.Add(btnAdd);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label lblMAIN;
        private Button btnView;
        private Button btnCheckout;
        private Button btnCheckin;
        private Button btnDepreciation;
        private Button btnDevice;
    }
}