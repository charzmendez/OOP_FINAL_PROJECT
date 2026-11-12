using Mendez_Dinalo_OOP_Finals.Interfaces;
using Mendez_Dinalo_OOP_Finals.Models;
using Mendez_Dinalo_OOP_Finals.Services;
using System;
using System.Collections.Generic;

namespace Mendez_Dinalo_OOP_Finals.Controllers
{
    public class AssetController
    {
        private readonly AssetService service;

        public AssetController(AssetService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public (bool Success, string Message) AddAsset(
            string type, string tag, string name, decimal price,
            string extra = null, int months = 0)
        {
            try
            {
                CampusAsset asset = type?.ToLower() switch
                {
                    "workstation" => new Workstation(tag, name, price, extra ?? ""),
                    "networking" => new NetworkingHardware(tag, name, price),
                    "peripheral" => new Peripheral(tag, name, price),
                    "license" => new SoftwareLicense(tag, name, price, months),
                    _ => throw new ArgumentException("Unknown asset type.")
                };

                if (asset is INetworkable net && !string.IsNullOrWhiteSpace(extra) && type == "networking")
                {
                    var parts = extra.Split('|');
                    if (parts.Length == 2)
                        net.AssignNetwork(parts[0], parts[1]);
                }

                service.Add(asset);
                return (true, "Asset added.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public List<CampusAsset> GetAll() => service.GetAll();

        public CampusAsset Get(string tag)
        {
            try { return service.Get(tag); }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }

        public string GetDetails(string tag)
        {
            var a = service.Get(tag);
            return a?.GetDetails() ?? "Asset not found.";
        }

        public string GetMaintenanceStatus(string tag)
        {
            var a = service.Get(tag);
            return a?.GetMaintenanceStatus() ?? "Asset not found.";
        }

        public string GetDepreciation(string tag)
        {
            var a = service.Get(tag);
            return a != null ? a.CalculateDepreciation().ToString("C") : "Asset not found.";
        }

        public (bool Success, string Message) Remove(string tag)
        {
            try
            {
                return service.Remove(tag)
                    ? (true, "Asset removed.")
                    : (false, "Asset not found.");
            }
            catch (Exception ex) { return (false, ex.Message); }
        }

        public (bool Success, string Message) CheckOut(string tag, string borrowerId)
        {
            try
            {
                service.CheckOut(tag, borrowerId);
                return (true, "Asset checked out.");
            }
            catch (Exception ex) { return (false, ex.Message); }
        }

        public (bool Success, string Message) Return(string tag)
        {
            try
            {
                service.Return(tag);
                return (true, "Asset returned.");
            }
            catch (Exception ex) { return (false, ex.Message); }
        }

        public (bool Success, string Message) SendToRepair(string tag)
        {
            try
            {
                service.SendToRepair(tag);
                return (true, "Asset sent to repair.");
            }
            catch (Exception ex) { return (false, ex.Message); }
        }

        public List<CampusAsset> GetCheckedOut() => service.GetCheckedOut();

        public List<CampusAsset> GetByMinPrice(decimal min) => service.GetByMinPrice(min);

        public List<CampusAsset> GetWorkstations() => service.GetByType<Workstation>();

        public List<CampusAsset> GetNetworking() => service.GetByType<NetworkingHardware>();

        public List<CampusAsset> GetPeripherals() => service.GetByType<Peripheral>();

        public List<CampusAsset> GetLicenses() => service.GetByType<SoftwareLicense>();

        public List<CampusAsset> SearchByName(string keyword) => service.SearchByName(keyword);

        public (bool Success, string Message) Save()
        {
            try { service.Save(); return (true, "Saved."); }
            catch (Exception ex) { return (false, ex.Message); }
        }
    }
}