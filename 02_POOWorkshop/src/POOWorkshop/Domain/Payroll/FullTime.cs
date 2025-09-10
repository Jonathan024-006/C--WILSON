namespace POOWorkshop.Domain.Payroll
{
    public class FullTime : EmployeeBase
    {
        public FullTime(string name, decimal salary) : base(name, salary) { }

        public override string BuildReport()
        {
            return $"Empleado FullTime: {Name}, Salario mensual: {Salary:C}";
        }
    }
}
