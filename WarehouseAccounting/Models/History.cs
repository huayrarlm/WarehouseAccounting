using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WarehouseAccounting.Models
{
    /// <summary>
    /// Класс истории с его значениями
    /// </summary>
    public partial class History
    {
        // === Первичный ключ ===
        [Key]
        [Column("IDистории")]
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

        // === Копии данных из Products (на момент операции) ===
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

        // === Данные операции ===
        [Column("Количество")]
        [Required]
        public int Quantity { get; set; }

        // === Копии данных из Client ===
        [Column("ФИО")]
        [StringLength(200)]
        [Required]
        public string ClientFullName { get; set; }

        [Column("Город")]
        [StringLength(100)]
        public string City { get; set; }

        [Column("Адрес")]
        [StringLength(200)]
        public string Address { get; set; }

        // === Данные операции ===
        [Column("Дата")]
        public DateTime OperationDate { get; set; }

        [Column("Кладовщик")]
        [StringLength(100)]
        public string Storekeeper { get; set; }

        // === Навигационные свойства ===
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
