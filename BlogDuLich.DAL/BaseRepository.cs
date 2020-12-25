using System;
using System.Data;
using System.Data.SqlClient;

namespace BlogDuLich.DAL
{ 
 public class BaseRepository
{
    protected IDbConnection connect;
    public BaseRepository()
    {
        connect = new SqlConnection(@"Data Source=DESKTOP-7VC9MRJ;Initial Catalog=BlogDuLich;Integrated Security=True");
    }
}
}