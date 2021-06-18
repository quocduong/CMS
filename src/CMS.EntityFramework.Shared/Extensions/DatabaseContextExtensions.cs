using CMS.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CMS.EntityFramework.Extensions
{
    public static class DatabaseContextExtensions
    {
        public static DatabaseContext CreateTransactionalDatabaseContext(this ITransactionalRepository repository, DbTransaction transaction)
        {
            if (transaction == null)
                return new DatabaseContext();

            var context = new DatabaseContext(transaction.Connection);

            context.Database.UseTransaction(transaction);

            return context;
        }
    }
}
