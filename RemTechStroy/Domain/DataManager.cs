using RemTechStroy.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemTechStroy.Domain
{
    public class DataManager
    {
        public ITableTemplateRepository TableTemplates { get; set; }

        public DataManager(ITableTemplateRepository tableTemplateRepository)
        {
            TableTemplates = tableTemplateRepository;
        }
    }
}
