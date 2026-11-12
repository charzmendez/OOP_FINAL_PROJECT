using System;
using System.Linq;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;

namespace Mendez_Dinalo.UI
{
    public partial class VIEWALLASSETFORM : Form
    {
        private readonly AssetController controller;

        public VIEWALLASSETFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void VIEWALLASSETFORM_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            var list = string.IsNullOrWhiteSpace(keyword)
                ? controller.GetAll()
                : controller.SearchByName(keyword);

            dataGridView1.DataSource = list.Select(a => new
            {
                Tag = a.AssetTag,
                Name = a.Name,
                Type = a.GetType().Name,
                Price = a.PurchasePrice,
                Status = a.Status,
                Maintenance = a.GetMaintenanceStatus(),
                Depreciation = a.CalculateDepreciation()
            }).ToList();

            lblTotal.Text = $" Total assets: {list.Count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(textBox1.Text.Trim());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox1.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}