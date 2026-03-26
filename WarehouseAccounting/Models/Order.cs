using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WarehouseAccounting.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Order
    {
        [Key]
        [Column("IDзаказа")]
        public Guid Id { get; set; }

        [Column("IDклиента")]
        [Required]
        public Guid ClientId { get; set; }

        [Column("IDтовара")]
        [Required]
        public Guid ProductId { get; set; }

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

        [Column("Количество")]
        [Required]
        public int Quantity { get; set; }


        /// <summary>
        /// Клиент, сделавший заказ
        /// </summary>
        //[ForeignKey("ClientId")]
        //public virtual Client Client { get; set; }

        ///// <summary>
        ///// Товар, который заказан
        ///// </summary>
        //[ForeignKey("ProductId")]
        //public virtual Product Product { get; set; }
    }
}
