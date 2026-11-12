namespace Mendez_Dinalo_OOP_Finals.Interfaces
{
    public interface IBorrowable
    {
        bool IsCheckedOut { get; }
        string BorrowerId { get; }
        void CheckOut(string borrowerId);
        void Return();
    }
}