using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsPackages
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True");
        }
    }
}
