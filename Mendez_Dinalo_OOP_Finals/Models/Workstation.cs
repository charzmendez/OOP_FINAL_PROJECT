using System;
using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo_OOP_Finals.Models
{
    public class Workstation : CampusAsset, IBorrowable, INetworkable
    {
        private string cpu;
        private bool checkedOut;
        private string borrowerId;
        private string ip;
        private string mac;

        public Workstation() : base() { }

        public Workstation(string tag, string name, decimal price, string cpu)
            : base(tag, name, price)
        {
            this.cpu = cpu;
        }

        public string Cpu => cpu;
        public bool IsCheckedOut => checkedOut;
        public string BorrowerId => borrowerId;
        public string IpAddress => ip;
        public string MacAddress => mac;

        public void CheckOut(string borrowerId)
        {
            if (Status == "In Repair")
                throw new InvalidOperationException("Asset is in repair and cannot be borrowed.");
            if (checkedOut)
                throw new InvalidOperationException("Asset is already checked out.");
            if (string.IsNullOrWhiteSpace(borrowerId))
                throw new ArgumentException("Borrower ID is required.");

            checkedOut = true;
            this.borrowerId = borrowerId;
            SetStatus("CheckedOut");
        }

        public void Return()
        {
            if (!checkedOut)
                throw new InvalidOperationException("Asset is not checked out.");
            checkedOut = false;
            borrowerId = null;
            MarkAvailable();
        }

        public void AssignNetwork(string ip, string mac)
        {
            this.ip = ip;
            this.mac = mac;
        }

        public override decimal CalculateDepreciation() => PurchasePrice / 5;

        public override string GetMaintenanceStatus() =>
            Status == "In Repair" ? "Needs technician" : "Operational";

        public override string GetDetails() =>
            base.GetDetails() + $" | Workstation | CPU: {cpu}";
    }
}