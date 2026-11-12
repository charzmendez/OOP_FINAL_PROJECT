using System;
using System.Linq;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo.UI
{
    public partial class CHECKINFORM : Form
    {
        private readonly AssetController controller;

        public CHECKINFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void CHECKINFORM_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadGrid();
        }

        private void LoadGrid()
        {
            var list = controller.GetCheckedOut();

            dataGridView1.DataSource = list.Select(a => new
            {
                Tag = a.AssetTag,
                Name = a.Name,
                BorrowedBy = (a as IBorrowable)?.BorrowerId
            }).ToList();

            comboBox1.Items.Clear();
            foreach (var a in list)
                comboBox1.Items.Add(a.AssetTag);
            comboBox1.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Cells["Tag"].Value != null)
            {
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Tag"].Value.ToString();
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            string tag = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(tag))
            {
                MessageBox.Show("Select an asset to check in.", "Missing info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = controller.Return(tag);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Check in failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controller.Save();
            MessageBox.Show("Asset returned.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}