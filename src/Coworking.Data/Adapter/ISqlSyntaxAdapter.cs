using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Adapter
{
    public interface ISqlSyntaxAdapter
    {
        public string NowExpr();
        string AddDaysExpr(string dateParam, int days);

        string LimitOneExpr(string orderByColumn, string direction = "DESC");
    }
}
