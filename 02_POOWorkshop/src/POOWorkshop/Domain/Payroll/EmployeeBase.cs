namespace POOWorkshop.Domain.Payroll
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public EmployeeBase(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        // 👇 Método abstracto que todas las clases hijas deben implementar
        public abstract string BuildReport();
    }
}
