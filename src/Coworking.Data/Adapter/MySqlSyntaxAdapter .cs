namespace Coworking.Data.Adapter
{
    public class MySqlSyntaxAdapter : ISqlSyntaxAdapter
    {
        public string NowExpr()
        {
            return "NOW()";
        }

        public string AddDaysExpr(string dateColumn, int days)
        {
            return $"DATE_ADD({dateColumn}, INTERVAL {days} DAY)";
        }

        public string LimitOneExpr(string orderByColumn, string direction = "DESC")
        {
            return $"ORDER BY {orderByColumn} {direction} LIMIT 1";
        }


    }
}
