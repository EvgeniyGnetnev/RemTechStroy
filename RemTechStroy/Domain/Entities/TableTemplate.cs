using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RemTechStroy.Domain.Entities
{
    public class TableTemplate : EntityBase
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Заполните наименование товара")]
        [Display(Name = "Наименование")]
        public override string Name { get; set; }
    }
}
