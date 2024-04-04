using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.SQLConnection
{
    public class SQLVariableContainer
    {
        /// <summary>
        /// The info about the local database. I use it to connect to my SQL server.
        /// </summary>
        public static string ConnectionToSQL = "Host=localhost;Port=5432;Database=RealMadridDB;Username=postgres;Password=123456";

        /// <summary>
        /// The select query to get the personal player ID to put it into a table where the ID is necessery.
        /// </summary>
        public static string SelectPersonalPlayerIdFromPersonalDetails = "(SELECT personal_details_id FROM personal_details ORDER BY personal_details_id DESC LIMIT 1)";
        
        /// <summary>
        /// Login page. We use it to get an employee data from database with the same login and password to authorize the account.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string SelectDataFromEmployeeOfRealMadrid(string login, string password)
        {
            return $"SELECT * FROM employee_of_real_madrid WHERE login = '{login}' AND password = '{password}'";
        } 
    }
}
