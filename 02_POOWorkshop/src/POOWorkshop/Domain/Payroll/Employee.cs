namespace POOWorkshop.Domain.Payroll;

public abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    protected Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public abstract decimal CalculatePayment();
}
