using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models
{
    public abstract class PoorEntity
    {
        [Key]
        public int Id { get; set; }

        /* [Display(Name = "Создатель", ShortName = "Создатель")]
         [DefaultValue(0)]
         public int UserCreator { get; set; }

         [Display(Name = "Дата создания", ShortName = "Дата созд.")]
         public DateTime DataCreate { get; set; }
         */
        public bool IsNew()
        {
            return Id == 0;
        }
    }
}
