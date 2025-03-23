using DDD.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Data
{
    public static class WeatherSQLite
    {
        public static DataTable GetLatest(int areaID)
        {
            string sql = @"
select DataDate,
       Condition, 
       Temperature
from Weather
where AreaId = @AreaId
order by DataDate desc
limit 1
";
            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(CommonConst.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AreaId", areaID);
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
