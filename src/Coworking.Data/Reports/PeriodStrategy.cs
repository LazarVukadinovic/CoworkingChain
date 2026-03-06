using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Reports
{
    public enum PeriodType
    {
        Hour1,
        Hour5,
        Day1,
        Week1,
        Month1,
        Month3,
        Month6,
        Year1
    }

    public class PeriodStrategy
    {
        private readonly PeriodType _period;

        public PeriodStrategy(PeriodType period)
        {
            _period = period;
        }

        public DateTime GetStartDate()
        {
            return _period switch
            {
                PeriodType.Hour1 => DateTime.Now.AddHours(-1),
                PeriodType.Hour5 => DateTime.Now.AddHours(-5),
                PeriodType.Day1 => DateTime.Now.AddDays(-1),
                PeriodType.Week1 => DateTime.Now.AddDays(-7),
                PeriodType.Month1 => DateTime.Now.AddMonths(-1),
                PeriodType.Month3 => DateTime.Now.AddMonths(-3),
                PeriodType.Month6 => DateTime.Now.AddMonths(-6),
                PeriodType.Year1 => DateTime.Now.AddYears(-1),
                _ => throw new ArgumentOutOfRangeException(nameof(_period), "Nepoznat period")
            };
        }
    }
}
