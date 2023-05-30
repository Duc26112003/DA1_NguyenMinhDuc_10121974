using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-RU1OHRH\SQLEXPRESS;Initial Catalog=DA1_NGUYENMINHDUC;Integrated Security=True");
    }
}









