using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Trust.Data.DbContext
{
    public class ApplicationRepository<T>: IApplicationRepository<T>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<T> GetData(string query)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                context.Database.OpenConnection();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return (T)reader[0];
                    }
                }

            }
        }

        public int GetReturnCount(string query)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                context.Database.OpenConnection();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    var count = 0;
                    while (reader.Read())
                    {
                        count = (int)reader["Counts"];
                    }

                    return count;
                }

            }
        }

        public GetReturnValue GetReturnedValue(string query, TheReturnType type)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                context.Database.OpenConnection();
                using (DbDataReader reader = command.ExecuteReader())
                {

                    GetReturnValue item = new GetReturnValue();
                    while (reader.Read())
                    {
                        item = (GetReturnValue)reader[0];
                    }

                    return item;
                }

            }
        }

        public void UpdateDataWithTrans(string query, SqlTransaction sqlTxn, SqlConnection con)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(con)
                .Options;
            using (var thecontext = new ApplicationDbContext(options))
            {
                thecontext.Database.UseTransaction(sqlTxn);
                thecontext.Database.ExecuteSqlCommand(query);
            }
        }

    }
}
