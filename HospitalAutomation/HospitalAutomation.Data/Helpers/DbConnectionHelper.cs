using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Helpers
{
    public class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS; database=HOSPITAL; integrated security=true;");
        }

    }
}
