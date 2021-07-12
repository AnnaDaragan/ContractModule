using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public class Service : PoorEntity
    {
        /*public Service()
        {
            this.InspectionServices = new HashSet<InspectionServices>();
            this.Reception = new HashSet<Reception>();
        }*/
        public string HashService { get; set; }
        public string Hash { get; set; }

        [Display(Name = "Услуга")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [DataType(DataType.Currency, ErrorMessage = "Значанеи должно быть числовым")]
        public double Price { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [ForeignKey("ServiceType")]
        [Display(Name = "Тип услуги")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public int IDServiceType { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public int Color { get; set; }
        public string Code { get; set; }

        [Display(Name = "Тип исследования")]
        [DefaultValue(false)]
        public bool ResearchType { get; set; }

        //public int IDParent { get; set; }
      
        [Display(Name = "Комплекс")]
        [DefaultValue(false)]
        public bool IsComplex { get; set; }

        [Display(Name = "Кабинет")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string Cabinet { get; set; }

        [Display(Name = "МКБ")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public int IDMKB { get; set; }

        //public virtual ICollection<InspectionServices> InspectionServices { get; set; }
        //public virtual ICollection<Reception> Reception { get; set; }

        [Display(Name = "Архивное", ShortName = "Арх.")]
        [DefaultValue(false)]
        public bool IsArchived { get; set; }
    }
}
