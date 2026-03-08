using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Adapter
{
    public class MsSqlSyntaxAdapter : ISqlSyntaxAdapter
    {
        public string NowExpr()
        {
            return "SYSDATETIME()";
        }
        public string AddDaysExpr(string dateColumn, int days)
        {
            return $"DATEADD(day, {days}, {dateColumn})";
        }
        public string LimitOneExpr(string orderByColumn, string direction = "DESC")
        {
            return $"ORDER BY {orderByColumn} {direction} OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
        }
    
    }
}
