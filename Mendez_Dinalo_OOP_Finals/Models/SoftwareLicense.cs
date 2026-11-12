using System;

namespace Mendez_Dinalo_OOP_Finals.Models
{
    public class SoftwareLicense : CampusAsset
    {
        private int monthsRemaining;

        public SoftwareLicense() : base() { }

        public SoftwareLicense(string tag, string name, decimal price, int monthsRemaining)
            : base(tag, name, price)
        {
            if (monthsRemaining < 0)
                throw new ArgumentException("Months remaining cannot be negative.");
            this.monthsRemaining = monthsRemaining;
        }

        public int MonthsRemaining => monthsRemaining;

        public override decimal CalculateDepreciation() =>
            PurchasePrice * (1 - (monthsRemaining / 60m));

        public override string GetMaintenanceStatus() =>
            monthsRemaining <= 0 ? "Expired" : $"Active ({monthsRemaining} months left)";

        public override string GetDetails() =>
            base.GetDetails() + $" | Software License | {monthsRemaining} months remaining";
    }
}