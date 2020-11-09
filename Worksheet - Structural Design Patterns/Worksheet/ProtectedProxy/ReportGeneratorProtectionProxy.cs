namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator;

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            // TODO
        }

        public string GenerateDailyReport()
        {
            throw new System.NotImplementedException();
        }
    }
}