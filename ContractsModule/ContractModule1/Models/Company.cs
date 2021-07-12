using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public class Company : PoorEntity
    {
        /* public Company()
         {
             this.Inspections = new HashSet<Inspection>();
         }*/

        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Описание не должно превышать 100 знаков")]
        [Required(ErrorMessage = "Значение не должно быть пустым")]
        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        //public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
