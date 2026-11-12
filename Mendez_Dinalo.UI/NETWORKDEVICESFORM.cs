using System;
using System.Linq;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Interfaces;
using Mendez_Dinalo_OOP_Finals.Models;

namespace Mendez_Dinalo.UI
{
    public partial class NETWORKDEVICESFORM : Form
    {
        private readonly AssetController controller;

        public NETWORKDEVICESFORM(AssetController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void NETWORKDEVICESFORM_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadGrid();
        }

        private void LoadGrid()
        {
            var networked = controller.GetAll()
                .OfType<INetworkable>()
                .Cast<CampusAsset>()
                .ToList();

            dataGridView1.DataSource = networked.Select(a =>
            {
                var n = (INetworkable)a;
                return new
                {
                    Tag = a.AssetTag,
                    Name = a.Name,
                    Type = a.GetType().Name,
                    IP = string.IsNullOrWhiteSpace(n.IpAddress) ? "(not set)" : n.IpAddress,
                    MAC = string.IsNullOrWhiteSpace(n.MacAddress) ? "(not set)" : n.MacAddress
                };
            }).ToList();

            lblDevicesno.Text = networked.Count.ToString();
            lblWithipno.Text = networked
                .Count(a => !string.IsNullOrWhiteSpace(((INetworkable)a).IpAddress))
                .ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}