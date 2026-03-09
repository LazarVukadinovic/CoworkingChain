using Coworking.Data.Providers;

namespace Coworking.Data.Reports
{
    public class CreateReport
    {
        private readonly IDataBase _proxy;

        public CreateReport(IDataBase proxy)
        {
            _proxy = proxy;
        }

        public List<ReportRow> GenerateReport(PeriodStrategy strategy)
        {
            DateTime start = strategy.GetStartDate();
            DateTime end = DateTime.Now;
            return _proxy.GetReportRows(start, end);
        }
    }
}
