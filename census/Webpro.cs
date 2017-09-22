using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace census
{
    class Webpro
    {
         public static SqlConnection My_Sql_Connection;
        public static SqlConnection GetConnection()
        {
            if (My_Sql_Connection == null)
            {
                My_Sql_Connection = new SqlConnection();
                My_Sql_Connection.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Mawaat\Projects\census\census\census\Database1.mdf;Integrated Security=True";
                My_Sql_Connection.Open();
            }
            return My_Sql_Connection;
        }

        
       
    }
}
