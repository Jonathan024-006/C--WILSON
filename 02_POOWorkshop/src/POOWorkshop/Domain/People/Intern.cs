namespace POOWorkshop.Domain.People
{
    public class Intern : Person
    {
        public decimal Salary { get; set; }

        public Intern(string fullName, decimal salary) : base(fullName)
        {
            Salary = salary;
        }
    }
}
