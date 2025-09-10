using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Domain.Payroll;


namespace POOWorkshop.Services.Payment;

public class OvertimeCalculator : IOvertimeCalculator
{
    private readonly int _baseHours;
    private readonly decimal _overtimeFactor;

    public OvertimeCalculator(int baseHours, decimal overtimeFactor)
    {
        _baseHours = baseHours;
        _overtimeFactor = overtimeFactor;
    }

    public decimal CalculateOvertime(decimal hourlyRate, int hoursWorked)
    {
        if (hoursWorked > _baseHours)
            return (hoursWorked - _baseHours) * hourlyRate * _overtimeFactor;
        return 0m;
    }

    // Extra: sobrecarga para Hourly
    public decimal CalculateOvertime(Hourly h) =>
        CalculateOvertime(h.HourlyRate, h.HoursWorked);
}

// Justificación de esta clase:
// OvertimeCalculator implementa una política específica de horas extra
// para los fines de semana. Al encapsular esta lógica en una clase separada que
// no tenga dependencias con otros componentes, podemos reutilizarla en otros
// contextos.