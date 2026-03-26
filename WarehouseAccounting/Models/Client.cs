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
    public partial class Client
    {
        [Key]
        [Column("IDклиента")]
        public Guid Id { get; set; }

        [Column("Имя")]
        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Имя должно быть от 2 до 100 символов")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Column("Фамилия")]
        [Required(ErrorMessage = "Фамилия обязательна")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Фамилия должна быть от 2 до 100 символов")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Column("Отчество")]
        [StringLength(100)]
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Column("Контакты")]
        [StringLength(20)]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Column("Город")]
        [StringLength(100)]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Column("Адрес")]
        [StringLength(200)]
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Column("Дата")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата регистрации")]
        public DateTime? RegistrationDate { get; set; }
    }
}
