using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RemTechStroy.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Display(Name = "Наименование")]
        public virtual string Name { get; set; }

        [Display(Name = "Количество")]
        public virtual string Amount { get; set; }

        [Display(Name = "Тип")]
        public virtual string Type { get; set; }

        [Display(Name = "Цена")]
        public virtual string Price { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
