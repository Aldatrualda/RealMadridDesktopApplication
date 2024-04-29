using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

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
        /// Login page. We use it to get count of an employee from database with the same login and password to authorize the account.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static string GetCountFromEmployeeOfRealMadrid(string login, string password) =>
            $"SELECT COUNT(*) FROM employee_of_real_madrid " +
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
        /// Show Employee Page. We use this query to show employees from database if the access modifier of a user is admin.
        /// Columns: ID, Name, Surname, Birthday, Phone Number, Login, Password.
        /// </summary>
        public static string SelectEmployeesFromRealMadridAdmin =
            "SELECT * FROM employee_of_real_madrid " +
            "   JOIN personal_details " +
            "       ON personal_details_id = personal_employee_details";

        /// <summary>
        /// Show Employee Page. We use this query to show employees from database if the access modifier of a user is coach. 
        /// Columns: ID, Name, Surname, Birthday, Phone Number.
        /// </summary>
        public static string SelectEmployeesFromRealMadridRestricted =
           "SELECT employee_id, name, surname, birthday, phone_number FROM employee_of_real_madrid " +
            "   JOIN personal_details " +
            "       ON personal_details_id = personal_employee_details";

        /// <summary>
        /// Show Player Page. We use this query to get and filter players from database if it requires.
        /// </summary>
        /// <param name="nationality"></param>
        /// <param name="location"></param>
        /// <param name="age"></param>
        public static string SelectFilteredPlayersFromRealMadrid(string nationality, string location, int age) =>
            "SELECT * FROM player_of_real_madrid " +
            "   JOIN personal_details " +
            "       ON personal_details_id = personal_player_details " +
            $"WHERE nationality LIKE '%{nationality}%' AND location LIKE '%{location}%' AND birthday > (" +
            $"                                                                                         SELECT now() - interval '{age} years')";
    }
}
