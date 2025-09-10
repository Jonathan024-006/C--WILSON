namespace POOWorkshop.Domain.People
{
    public class EmployeeFullTimePerson : Person
    {
        public decimal Salary { get; set; }

        public EmployeeFullTimePerson(string fullName, decimal salary) : base(fullName)
        {
            Salary = salary;
        }
    }
}
