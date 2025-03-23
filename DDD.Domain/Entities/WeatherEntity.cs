

using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        //完全コンストラクタパターン
        public WeatherEntity(int areaId,
            DateTime dataDate,
            int condition,
            float temperature)
        {
            AreaId = areaId;
            DataDate = dataDate;
            Condition = condition;
            Temperature = temperature;
        }
        //      dt.Columns.Add("AreaId", typeof(int));
        //dt.Columns.Add("DataDate", typeof(DateTime));
        //      dt.Columns.Add("Condition", typeof(int));
        //      dt.Columns.Add("Temperature", typeof(float));

        public int AreaId { get;  }
        public DateTime DataDate { get;  }
        public int Condition { get;  }
        public float Temperature { get; }

        public bool IsOK()
        {
            if(DataDate < DateTime.Now.AddMonths(-1))
            {
                return false;
            }

            return true;
        }

    }
}
