using System.ComponentModel.DataAnnotations;

namespace Praxis.Data.Entities.Admin
{
    public class Warehouse : AuditableEntity
    {
        public enum WarehouseType
        {
            Active = 1, Waste = 2, LongTerm = 3
        }
        [Key, StringLength(8)] public string WarehouseRef { get; set; } = default!;
        [Required, StringLength(60)] public string WarehouseName { get; set; } = default!;
        [StringLength(60)] public string? AddressLine1 { get; set; }
        [StringLength(60)] public string? AddressLine2 { get; set; }
        [StringLength(60)] public string? City { get; set; }
        [StringLength(60)] public string? County { get; set; }
        [StringLength(10)] public string? PostalCode { get; set; }

        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }

        public WarehouseType TypeOfWarehouse { get; set; } = WarehouseType.Active;
        public bool IsDefault { get; set; } = false;
        public string? Notes { get; set; }
    }
}
