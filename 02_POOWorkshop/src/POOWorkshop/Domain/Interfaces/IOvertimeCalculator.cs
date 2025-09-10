namespace POOWorkshop.Domain.Interfaces;

public interface IOvertimeCalculator
{
    decimal CalculateOvertime(decimal hourlyRate, int hoursWorked);
}
