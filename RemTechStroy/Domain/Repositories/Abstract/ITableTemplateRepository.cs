using RemTechStroy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemTechStroy.Domain.Repositories.Abstract
{
    public interface ITableTemplateRepository
    {
        IQueryable<TableTemplate> GetTableItems();
        TableTemplate GetTableItemById(int id);
        void SaveTableItem(TableTemplate entity);
        void DeleteTableItem(int id);
    }
}
