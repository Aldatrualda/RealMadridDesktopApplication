using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.SQLConnection
{
    public class SQLConnection
    {
        public static string ConnectionToSQL= "Host=localhost;Port=5432;Database=RealMadridDB;Username=postgres;Password=123456";

        public static string SelectPersonalPlayerIdFromPersonalDetails()
        {
            return "(SELECT personal_details_id FROM personal_details ORDER BY personal_details_id DESC LIMIT 1)";
        }
    }
}
