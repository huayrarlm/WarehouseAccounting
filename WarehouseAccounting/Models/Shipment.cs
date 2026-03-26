using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    public partial class Shipment
    {
        // === Первичный ключ ===
        [Key]
        [Column("IDотгрузки")]
        public Guid Id { get; set; }

        // === Внешние ключи ===
        [Column("IDтовара")]
        [Required]
        public Guid ProductId { get; set; }

        [Column("IDклиента")]
        [Required]
        public Guid ClientId { get; set; }

        [Column("IDпользователя")]
        [Required]
        public Guid UserId { get; set; }

        // === Копии данных из Products (на момент отгрузки) ===
        [Column("Артикул")]
        [StringLength(50)]
        [Required]
        public string SKU { get; set; }

        [Column("Название")]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [Column("Категория")]
        [StringLength(100)]
        public string Category { get; set; }

        [Column("ЕдИзмерения")]
        [StringLength(20)]
        public string Unit { get; set; }

        [Column("Цена")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        // === Данные отгрузки ===
        [Column("Количество")]
        [Required]
        public int Quantity { get; set; }

        [Column("ОстатокПосле")]
        public int RemainingAfter { get; set; }

        [Column("Наличие")]
        public bool IsAvailable { get; set; } = true;


        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
