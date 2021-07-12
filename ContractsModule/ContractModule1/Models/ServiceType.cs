using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public class ServiceType : PoorEntity
    {
        public ServiceType()
        {
           // this.DoctorServices = new HashSet<DoctorServices>();
            this.Services = new HashSet<Service>();
        }

        //public virtual ICollection<DoctorServices> DoctorServices { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        [Display(Name = "Тип услуги")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        public string Name { get; set; }

        [MaxLength(100)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public override string ToString()
        {
            return Name;
        }

        [Display(Name = "Архивное", ShortName = "Арх.")]
        [DefaultValue(false)]
        public bool IsArchived { get; set; }
    }
}
