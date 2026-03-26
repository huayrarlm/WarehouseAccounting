using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WarehouseAccounting.Models
{
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

        //[Display(Name = "Дата создания")]
        //public DateTime CreatedAt { get; set; }

        //[Display(Name = "Дата обновления")]
        //public DateTime? UpdatedAt { get; set; }

        //[StringLength(100)]
        //[Display(Name = "Создал")]
        //public string CreatedBy { get; set; }

        //[StringLength(100)]
        //[Display(Name = "Обновил")]
        //public string UpdatedBy { get; set; }

        // Вычисляемое поле для отображения номера (не хранится в БД)
        [NotMapped]
        [Display(Name = "№")]
        public int RowNumber { get; set; }
    }
}
