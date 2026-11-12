using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Models;

namespace Mendez_Dinalo.UI
{
    public partial class DEPRICIATIONFORM : Form
    {
        private readonly AssetController controller;

        public DEPRICIATIONFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void DEPRICIATIONFORM_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[]
            {
                "All", "Workstation", "Networking", "Peripheral", "License"
            });
            comboBox1.SelectedIndex = 0;
            LoadGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            string filter = comboBox1.SelectedItem?.ToString() ?? "All";

            List<CampusAsset> list;

            switch (filter)
            {
                case "Workstation":
                    list = controller.GetWorkstations();
                    break;
                case "Networking":
                    list = controller.GetNetworking();
                    break;
                case "Peripheral":
                    list = controller.GetPeripherals();
                    break;
                case "License":
                    list = controller.GetLicenses();
                    break;
                default:
                    list = controller.GetAll();
                    break;
            }

            dataGridView1.DataSource = list.Select(a => new
            {
                Tag = a.AssetTag,
                Name = a.Name,
                Type = a.GetType().Name,
                Price = a.PurchasePrice,
                Depreciation = a.CalculateDepreciation()
            }).ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblTotalassetno.Text = list.Count.ToString();
            lblTotalannualdepreciationno.Text =
                list.Sum(a => a.CalculateDepreciation()).ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}