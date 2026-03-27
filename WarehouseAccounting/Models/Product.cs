using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WarehouseAccounting.Models
{
    /// <summary>
    /// Класс товаров с его значениями
    /// </summary>
    public partial class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Артикул обязателен")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Артикул должен быть от 1 до 50 символов")]
        [Display(Name = "Артикул")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Название должно быть от 1 до 200 символов")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Категория")]
        public string Category { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Цена закупки")]
        public decimal? Price { get; set; }

        [StringLength(20)]
        [Display(Name = "Единица измерения")]
        public string Unit { get; set; }

        [Display(Name = "Текущий остаток")]
        public int Quantity { get; set; }

        [NotMapped]
        [Display(Name = "№")]
        public int RowNumber { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<History> History { get; set; }

        public Product()
        {
            Orders = new List<Order>();
            Shipments = new List<Shipment>();
            History = new List<History>();
        }
    }
}
