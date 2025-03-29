using System;

namespace DDD.Domain.Helpers
{
    /// <summary>
    /// 小数点以下を指定桁数で四捨五入します
    /// </summary>
    public static class FloatHelper
    {
        public static string RoundString(this float value, int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(value, decimalPoint));
            return temp.ToString("F" + decimalPoint);
        }


    }
}
