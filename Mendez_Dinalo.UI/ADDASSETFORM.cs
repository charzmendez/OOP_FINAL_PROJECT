using System;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo.UI
{
    public partial class ADDASSETFORM : Form
    {
        private readonly AssetController controller;

        public ADDASSETFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void ADDASSETFORM_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[]
            {
                "Workstation", "Networking", "Peripheral", "License"
            });
            comboBox1.SelectedIndex = 0;
            numericUpDown2.Maximum = 10000;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem?.ToString() ?? "Workstation";

            textBox3.Enabled = false; textBox3.Clear();
            textBox4.Enabled = false; textBox4.Clear();
            textBox5.Enabled = false; textBox5.Clear();
            numericUpDown2.Enabled = false; numericUpDown2.Value = 0;

            switch (type)
            {
                case "Workstation":
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    break;
                case "Networking":
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    break;
                case "Peripheral":
                    break;
                case "License":
                    numericUpDown2.Enabled = true;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem?.ToString() ?? "";
            string tag = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            decimal price = numericUpDown1.Value;

            (bool Success, string Message) result;

            switch (type)
            {
                case "Workstation":
                    result = controller.AddAsset("workstation", tag, name, price, textBox3.Text.Trim());

                    if (result.Success && (!string.IsNullOrWhiteSpace(textBox4.Text) ||
                                           !string.IsNullOrWhiteSpace(textBox5.Text)))
                    {
                        var saved = controller.Get(tag);
                        if (saved is INetworkable netWs)
                        {
                            netWs.AssignNetwork(textBox4.Text.Trim(), textBox5.Text.Trim());
                        }
                    }
                    break;

                case "Networking":
                    string ipMac = $"{textBox4.Text.Trim()}|{textBox5.Text.Trim()}";
                    result = controller.AddAsset("networking", tag, name, price, ipMac);
                    break;

                case "Peripheral":
                    result = controller.AddAsset("peripheral", tag, name, price);
                    break;

                case "License":
                    result = controller.AddAsset("license", tag, name, price, null, (int)numericUpDown2.Value);
                    break;

                default:
                    result = (false, "Unknown asset type.");
                    break;
            }

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Cannot add asset",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controller.Save();
            MessageBox.Show("Asset added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            comboBox1.SelectedIndex = 0;
        }
    }
}