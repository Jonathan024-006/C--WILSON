namespace POOWorkshop.Domain.People
{
    public class Manager : Person
    {
        public decimal Salary { get; set; }

        public Manager(string fullName, decimal salary) : base(fullName)
        {
            Salary = salary;
        }
    }
}
