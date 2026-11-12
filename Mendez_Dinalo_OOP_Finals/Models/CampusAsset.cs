using System;
using System.Text.Json.Serialization;

namespace Mendez_Dinalo_OOP_Finals.Models
{
    [JsonDerivedType(typeof(Workstation), "workstation")]
    [JsonDerivedType(typeof(NetworkingHardware), "networking")]
    [JsonDerivedType(typeof(Peripheral), "peripheral")]
    [JsonDerivedType(typeof(SoftwareLicense), "license")]
    public abstract class CampusAsset
    {
        private string assetTag;
        private string name;
        private decimal purchasePrice;
        private string status;

        public string AssetTag => assetTag;
        public string Name => name;
        public decimal PurchasePrice => purchasePrice;
        public string Status => status;

        protected CampusAsset()
        {
            assetTag = "";
            name = "";
            status = "Available";
        }

        protected CampusAsset(string tag, string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(tag))
                throw new ArgumentException("Asset tag is required.");
            if (price < 0)
                throw new ArgumentException("Purchase price cannot be negative.");

            assetTag = tag;
            this.name = name;
            purchasePrice = price;
            status = "Available";
        }

        public abstract string GetMaintenanceStatus();
        public abstract decimal CalculateDepreciation();

        public void SendToRepair()
        {
            if (status == "CheckedOut")
                throw new InvalidOperationException("Cannot send a checked-out asset to repair.");
            status = "In Repair";
        }

        public void MarkAvailable()
        {
            if (status != "CheckedOut")
                status = "Available";
        }

        internal void SetStatus(string newStatus) => status = newStatus;

        public virtual string GetDetails() =>
            $"[{AssetTag}] {Name} (${PurchasePrice}) — {Status}";
    }
}