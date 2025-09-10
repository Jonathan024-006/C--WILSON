namespace POOWorkshop.Domain.Payroll
{
    public class Hourly : EmployeeBase
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        // 🔹 Constructor que recibe 3 parámetros
        public Hourly(string name, int hoursWorked, decimal hourlyRate)
            : base(name, hoursWorked * hourlyRate) // calcula salario base
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override string BuildReport()
        {
            return $"Empleado por horas: {Name}, Horas: {HoursWorked}, Tarifa: {HourlyRate:C}, Salario: {Salary:C}";
        }
    }
}
