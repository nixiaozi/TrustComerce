using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Trust.Data.DbContext
{
    public interface IApplicationRepository<T>
    {
        IEnumerable<T> GetData(string query);

        int GetReturnCount(string query);

        GetReturnValue GetReturnedValue(string query, TheReturnType type);

        void UpdateDataWithTrans(string query, SqlTransaction sqlTxn, SqlConnection con);
    }
}
