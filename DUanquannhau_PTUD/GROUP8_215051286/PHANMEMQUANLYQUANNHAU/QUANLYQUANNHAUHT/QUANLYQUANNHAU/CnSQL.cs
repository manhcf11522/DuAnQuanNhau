using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QUANLYQUANNHAU
{

    public class CnSQL
    {
        public static string linksql = "Data Source=MYYY\\MSSQLSERVER05;Initial Catalog=DULIEUQUANLYQUANNHAU;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return  new SqlConnection(linksql);
        }

    }
    
}
