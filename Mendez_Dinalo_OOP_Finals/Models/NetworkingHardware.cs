using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo_OOP_Finals.Models
{
    public class NetworkingHardware : CampusAsset, INetworkable
    {
        private string ip;
        private string mac;

        public NetworkingHardware() : base() { }

        public NetworkingHardware(string tag, string name, decimal price)
            : base(tag, name, price) { }

        public string IpAddress => ip;
        public string MacAddress => mac;

        public void AssignNetwork(string ip, string mac)
        {
            this.ip = ip;
            this.mac = mac;
        }

        public override decimal CalculateDepreciation() => PurchasePrice / 8;

        public override string GetMaintenanceStatus() =>
            Status == "In Repair" ? "Firmware check required" : "Online";

        public override string GetDetails() =>
            base.GetDetails() + " | Networking Hardware";
    }
}