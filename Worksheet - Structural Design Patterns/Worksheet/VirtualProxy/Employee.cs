namespace VirtualProxy
{
    public sealed class Employee
    {
        public string EmployeeName { get; }
        public decimal EmployeeSalary { get; }
        public string EmployeeDesignation { get; }

        public Employee(string employeeName, decimal employeeSalary, string employeeDesignation)
        {
            // TODO
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE?
        }
    }
}