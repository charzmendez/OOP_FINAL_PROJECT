using System.Collections.Generic;
using Mendez_Dinalo_OOP_Finals.Models;

namespace Mendez_Dinalo_OOP_Finals.Interfaces
{
    public interface IAssetRepository
    {
        Dictionary<string, CampusAsset> Load();
        void Save(Dictionary<string, CampusAsset> assets);
    }
}