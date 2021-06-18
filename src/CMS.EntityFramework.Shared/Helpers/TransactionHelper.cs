using CMS.Shared.Configurations;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Helpers
{
    public static class TransactionHelper
    {
        private static AppSettings AppSettings;

        public static async Task<bool> ExecuteInTransactionAsync(Func<DbTransaction, Task> transactionalTask, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
            => await ExecuteInTransactionAsync(new List<Func<DbTransaction, Task>> { transactionalTask }, isolationLevel: isolationLevel);

        public static async Task<bool> ExecuteInTransactionAsync(List<Func<DbTransaction, Task>> transactionalTaskList, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            using var connection = new SqlConnection(AppSettings.DefaultConnection);
            connection.Open();

            using var transaction = await connection.BeginTransactionAsync(isolationLevel);
            try
            {
                await Task.WhenAll(transactionalTaskList.Select(fn => fn(transaction)).ToArray());
                transaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                Log.Error(ex, "Execute task(s) in Transaction failed due to: " + ex.Message);
                return false;
            }
        }
    }
}
