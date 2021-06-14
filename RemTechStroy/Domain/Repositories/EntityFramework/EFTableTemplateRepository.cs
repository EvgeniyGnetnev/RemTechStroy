using Microsoft.EntityFrameworkCore;
using RemTechStroy.Domain.Entities;
using RemTechStroy.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemTechStroy.Domain.Repositories.EntityFramework
{
    public class EFTableTemplateRepository : ITableTemplateRepository
    {
        private readonly AppDbContext context;
        public EFTableTemplateRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<TableTemplate> GetTableItems()
        {
            return context.productTable;
        }

        public TableTemplate GetTableItemById(int id)
        {
            return context.productTable.FirstOrDefault(x => x.id == id);
        }

        public void SaveTableItem(TableTemplate entity)
        {
            if (entity.id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTableItem(int id)
        {
            context.productTable.Remove(new TableTemplate() { id = id });
            context.SaveChanges();
        }
    }
}
