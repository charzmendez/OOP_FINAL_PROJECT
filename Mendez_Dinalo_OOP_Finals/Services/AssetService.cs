using System;
using System.Collections.Generic;
using System.Linq;
using Mendez_Dinalo_OOP_Finals.Interfaces;
using Mendez_Dinalo_OOP_Finals.Models;

namespace Mendez_Dinalo_OOP_Finals.Services
{
    // Business logic layer — UI talks to this, not the dictionary directly.
    public class AssetService
    {
        private readonly Dictionary<string, CampusAsset> assets;
        private readonly IAssetRepository repository;

        public AssetService(IAssetRepository repository)
        {
            this.repository = repository;
            assets = repository.Load();
        }

        // ---------- CRUD ----------
        public void Add(CampusAsset asset)
        {
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));
            if (assets.ContainsKey(asset.AssetTag))
                throw new InvalidOperationException($"Asset tag '{asset.AssetTag}' already exists.");
            assets[asset.AssetTag] = asset;
        }

        public CampusAsset Get(string tag)
        {
            return assets.TryGetValue(tag, out var a) ? a : null;
        }

        public bool Remove(string tag) => assets.Remove(tag);

        public List<CampusAsset> GetAll() => assets.Values.ToList();

        public int Count => assets.Count;

        // ---------- Borrow / Return ----------
        public void CheckOut(string tag, string borrowerId)
        {
            var asset = Get(tag) ?? throw new InvalidOperationException("Asset not found.");
            if (asset is not IBorrowable borrowable)
                throw new InvalidOperationException("This asset cannot be borrowed.");
            borrowable.CheckOut(borrowerId);
        }

        public void Return(string tag)
        {
            var asset = Get(tag) ?? throw new InvalidOperationException("Asset not found.");
            if (asset is not IBorrowable borrowable)
                throw new InvalidOperationException("This asset cannot be borrowed.");
            borrowable.Return();
        }

        // ---------- Maintenance ----------
        public void SendToRepair(string tag)
        {
            var asset = Get(tag) ?? throw new InvalidOperationException("Asset not found.");
            asset.SendToRepair();
        }

        // ---------- LINQ Queries ----------
        public List<CampusAsset> GetCheckedOut()
        {
            return assets.Values
                .OfType<IBorrowable>()
                .Where(b => b.IsCheckedOut)
                .Cast<CampusAsset>()
                .ToList();
        }

        public List<CampusAsset> GetByMinPrice(decimal minPrice)
        {
            return assets.Values
                .Where(a => a.PurchasePrice >= minPrice)
                .ToList();
        }

        public List<CampusAsset> GetByType<T>() where T : CampusAsset
        {
            return assets.Values.OfType<T>().Cast<CampusAsset>().ToList();
        }

        public List<CampusAsset> SearchByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            return assets.Values
                .Where(a => a.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // ---------- Persistence ----------
        public void Save() => repository.Save(assets);

        public void Reload() => repository.Load();
    }
}