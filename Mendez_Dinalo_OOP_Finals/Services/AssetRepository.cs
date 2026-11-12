using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Mendez_Dinalo_OOP_Finals.Interfaces;
using Mendez_Dinalo_OOP_Finals.Models;

namespace Mendez_Dinalo_OOP_Finals.Services
{
    public class AssetRepository : IAssetRepository
    {
        private readonly string filePath;

        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true,
            IncludeFields = true
        };

        public AssetRepository(string filePath = "mendez_dinalo_assets.json")
        {
            this.filePath = filePath;
        }

        public Dictionary<string, CampusAsset> Load()
        {
            try
            {
                if (!File.Exists(filePath))
                    return new Dictionary<string, CampusAsset>();

                string json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<Dictionary<string, CampusAsset>>(json, Options);
                return data ?? new Dictionary<string, CampusAsset>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load failed: {ex.Message}");
                return new Dictionary<string, CampusAsset>();
            }
        }

        public void Save(Dictionary<string, CampusAsset> assets)
        {
            try
            {
                string json = JsonSerializer.Serialize(assets, Options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Save failed: {ex.Message}");
            }
        }
    }
}