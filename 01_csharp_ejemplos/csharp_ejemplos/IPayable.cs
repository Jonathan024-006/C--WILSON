using System;
using System.Collections.Generic;

// Interfaz para reportes
public interface IReportable
{
    string BuildReport();
}

// Clase abstracta base
public abstract class EmployeeBase : IReportable, IPayable
{
    public string FullName { get; }
    protected EmployeeBase(string name) => FullName = name;

    public abstract decimal CalculatePayment();
    public abstract string BuildReport();
}

// Tiempo completo
public class FullTime : EmployeeBase
{
    public decimal Monthly { get; }
    public FullTime(string name, decimal monthly) : base(name) => Monthly = monthly;

    public override decimal CalculatePayment() => Monthly;

    public override string BuildReport() => $"Empleado FT: {FullName}, pago: {CalculatePayment():C0}";
}

// Por horas
public class Hourly : EmployeeBase
{
    public decimal Rate { get; }
    public int Hours { get; }
    public decimal TaxRate { get; } = 0.1m; // 10% de retención

    public Hourly(string name, decimal rate, int hours) : base(name) { Rate = rate; Hours = hours; }

    public override decimal CalculatePayment() => Rate * Hours;

    public override string BuildReport()
    {
        var gross = CalculatePayment();
        var tax = gross * TaxRate;
        var net = gross - tax;
        return $"Empleado Hourly: {FullName}, bruto: {gross:C0}, retención: {tax:C0}, neto: {net:C0}";
    }
}

/* Ejercicio 3
   Crea IReportable con string BuildReport().
   Implementa en FullTime y Hourly.
   Recorre List<IReportable> y muestra reportes.
   Plus: agrega TaxRate y calcula retenciones (sólo en Hourly).
*/
