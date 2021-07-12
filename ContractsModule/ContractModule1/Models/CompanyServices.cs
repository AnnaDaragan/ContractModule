using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public class CompanyServices : PoorEntity
    {
        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [DataType(DataType.Currency, ErrorMessage ="Значанеи должно быть числовым")]
        public double Price { get; set; }
        public string Hash { get; set; }

        [NotMapped]
        public string Name { get; set; }

        [NotMapped]
        public string ServiceType { get; set; }

        [ForeignKey("Contract")]
        [Display(Name = "Номер контракта")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public int IDContract { get; set; }
        public virtual ContractCompany Contract { get; set; }

        [ForeignKey("Service")]
        [Display(Name = "Услуга")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public int IDService { get; set; }
        public virtual Service Service { get; set; }

        [Display(Name = "Архивное", ShortName = "Арх.")]
        [DefaultValue(false)]
        public bool IsArchived { get; set; }
    }
}
