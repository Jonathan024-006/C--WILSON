using POOWorkshop.Domain.Interfaces;

namespace POOWorkshop.Services.Payment;

public class WeekendOvertimeCalculator : IOvertimeCalculator
{
    private readonly int _baseHours;

    public WeekendOvertimeCalculator(int baseHours = 8)
    {
        _baseHours = baseHours;
    }

    public decimal CalculateOvertime(decimal hourlyRate, int hoursWorked)
    {
        // Si trabaja más de 8h un día del fin de semana → 1.5x
        if (hoursWorked > _baseHours)
            return (hoursWorked - _baseHours) * hourlyRate * 1.5m;
        return 0m;
    }
}

// Justificación de esta clase:
// WeekendOvertimeCalculator implementa una política específica de horas extra
// para los fines de semana. Al encapsular esta lógica en una clase separada que
// no tenga dependencias con otros componentes, podemos reutilizarla en otros
// contextos.