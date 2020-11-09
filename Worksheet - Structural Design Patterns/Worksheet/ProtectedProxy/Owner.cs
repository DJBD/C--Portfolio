namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        public bool IsOwner()
        {
            throw new System.NotImplementedException();
        }

        public string GenerateDailyReport()
        {
            throw new System.NotImplementedException();
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}