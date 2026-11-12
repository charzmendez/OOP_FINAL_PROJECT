using System;
using System.Windows.Forms;
using Mendez_Dinalo_OOP_Finals.Controllers;
using Mendez_Dinalo_OOP_Finals.Services;

namespace Mendez_Dinalo.UI
{
    public partial class MainMenu : Form
    {
        private readonly AssetController controller;

        public MainMenu()
        {
            InitializeComponent();

            var repo = new AssetRepository();
            var svc = new AssetService(repo);
            controller = new AssetController(svc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDASSETFORM f = new ADDASSETFORM(controller);
            f.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            VIEWALLASSETFORM f = new VIEWALLASSETFORM(controller);
            f.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CHECKOUTFORM f = new CHECKOUTFORM(controller);
            f.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            CHECKINFORM f = new CHECKINFORM(controller);
            f.ShowDialog();
        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {
            DEPRICIATIONFORM f = new DEPRICIATIONFORM(controller);
            f.ShowDialog();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            NETWORKDEVICESFORM f = new NETWORKDEVICESFORM(controller);
            f.ShowDialog();
        }
    }
}