using System;
using Mendez_Dinalo_OOP_Finals.Interfaces;

namespace Mendez_Dinalo_OOP_Finals.Models
{
    public class Peripheral : CampusAsset, IBorrowable
    {
        private bool checkedOut;
        private string borrowerId;

        public Peripheral() : base() { }

        public Peripheral(string tag, string name, decimal price)
            : base(tag, name, price) { }

        public bool IsCheckedOut => checkedOut;
        public string BorrowerId => borrowerId;

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

        public override decimal CalculateDepreciation() => PurchasePrice / 3;

        public override string GetMaintenanceStatus() => "Functional";

        public override string GetDetails() =>
            base.GetDetails() + " | Peripheral";
    }
}