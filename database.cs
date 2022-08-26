using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ziyaretcikayit
{
    class database
    {
        /// <summary>
        /// datagridviewde veri çekmek için database sınıfı oluşturdum.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=.;Initial Catalog=ziyaretcikayit;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
