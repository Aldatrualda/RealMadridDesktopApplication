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
        public static string SelectPersonalPlayerIdFromPersonalDetails =
            "SELECT personal_details_id FROM personal_details " +
            "ORDER BY personal_details_id DESC LIMIT 1";

        /// <summary>
        /// Login page. We use it to get an employee data from database with the same login and password to authorize the account.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static string SelectDataFromEmployeeOfRealMadrid(string login, string password) => 
            $"SELECT * FROM employee_of_real_madrid " +
            $"WHERE login = '{login}' AND password = '{password}'";
        
        /// <summary>
        /// Login page. We use it to get an user access modifier. According to the access modifier it has different access to app abilities.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static string SelectAccessModifierOfUser(string login, string password) => 
            $"SELECT type_of_viewer FROM access_modifier " +
            $"  JOIN employee_of_real_madrid " +
            $"      ON employee_of_real_madrid.role_access = access_modifier.access_modifier_id " +
            $"WHERE login = '{login}' AND password = '{password}'";

        /// <summary>
        /// Show player page. We use this query to show players from database.
        /// </summary>
        public static string SelectPlayersFromRealMadrid = 
            "SELECT * FROM player_of_real_madrid " +
            "   JOIN personal_details " +
            "       ON personal_details_id = personal_player_details";

        /// <summary>
        /// Show Employee Page. We use this query to show employees from database.
        /// </summary>
        public static string SelectEmployeesFromRealMadrid = 
            "SELECT * FROM employee_of_real_madrid " +
            "   JOIN personal_details " +
            "       ON personal_details_id = personal_employee_details";
    }
}
