using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public class ContractCompany : PoorEntity
    {
        public ContractCompany()
        {
            CompanyServiceses = new HashSet<CompanyServices>();
        }

        [Display(Name = "Активный")]
        [DefaultValue(false)]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public DateTime? DateTime { get; set; }

        [ForeignKey("Company")]
        [Display(Name = "Компания")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public int IDCompany { get; set; }
        public virtual Company Company { get; set; }

        [Display(Name = "Номер контракта")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string NumberContract { get; set; }

        [MaxLength(9)]
        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string INN { get; set; }

        [Display(Name = "КПП")]
        public string KPP { get; set; }

        [MaxLength(9)]
        [Display(Name = "БИК")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string BIK { get; set; }

        [MaxLength(13)]
        [Display(Name = "ОГРН")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string OGRN { get; set; }

        [MaxLength(20)]
        [Display(Name = "Расчетный счет")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string CheckingAccount { get; set; }

        [MaxLength(20)]
        [Display(Name = "Кор. счет")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string CorrectiveAccount { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string ChiefFirstName { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string ChiefSecondName { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string ChiefThreeName { get; set; }
        public virtual ICollection<CompanyServices> CompanyServiceses { get; set; }

        [NotMapped]
        public string Fio => $"{ChiefSecondName} {ChiefFirstName} {ChiefThreeName}";

        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string Address { get; set; }

        [Display(Name = "Банк")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string Bank { get; set; }

        [NotMapped]
        public string FioShort => $"{ChiefSecondName} {(ChiefFirstName.Length > 0 ? (ChiefFirstName[0] + ".") : (" "))} {(ChiefThreeName.Length > 0 ? (ChiefThreeName[0] + ".") : (" "))}";
    }
}
