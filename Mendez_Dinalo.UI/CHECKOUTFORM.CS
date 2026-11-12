using System;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo.UI
{
    public partial class CHECKOUTFORM : Form
    {
        private readonly AssetController controller;

        public CHECKOUTFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void CHECKOUTFORM_Load(object sender, EventArgs e)
        {
            btnCheckout.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string tag = textBox1.Text.Trim();
            var asset = controller.Get(tag);

            if (asset == null)
            {
                comboBox1.Text = "Not found";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                btnCheckout.Enabled = false;
                return;
            }

            comboBox1.Text = asset.Name;
            comboBox2.Text = asset.GetType().Name;
            comboBox3.Text = asset.Status;

            bool canBorrow = asset is IBorrowable b && !b.IsCheckedOut;
            comboBox4.Text = canBorrow ? "Yes" : "No";
            btnCheckout.Enabled = canBorrow;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string tag = textBox1.Text.Trim();
            string student = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(student))
            {
                MessageBox.Show("Please enter a Student ID.", "Missing info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = controller.CheckOut(tag, student);
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Check out failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controller.Save();
            MessageBox.Show("Asset checked out.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCheck_Click(object sender, EventArgs e) { }
        private void lblType_Click(object sender, EventArgs e) { }
    }
}