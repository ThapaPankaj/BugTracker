using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugtracker
{
    class databaseConnection
    {
      public void DatabaseConnection()
        {
            string databaseConnection;
            databaseConnection = "datasource = localhost; username = root; password = umapunkoz; database = bugtracker";
            MySqlConnection myconn = new MySqlConnection(databaseConnection);
            myconn.Open();
        }      

    }
}
