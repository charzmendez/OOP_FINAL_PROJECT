namespace Mendez_Dinalo_OOP_Finals.Interfaces
{
    public interface INetworkable
    {
        string IpAddress { get; }
        string MacAddress { get; }
        void AssignNetwork(string ip, string mac);
    }
}