using System;

public class Person
{
    public string FullName { get; }
    public Person(string fullName) => FullName = fullName;

    // Método virtual para describir a la persona
    public virtual string Describe() => $"Persona: {FullName}";
}

public class EmployeeFullTime : Person
{
    public decimal Salary { get; }
    public EmployeeFullTime(string name, decimal salary) : base(name) => Salary = salary;

    // Sobrescribe Describe para mostrar salario
    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}";
}

// Manager hereda de EmployeeFullTime
public class Manager : EmployeeFullTime
{
    public int TeamSize { get; }
    public Manager(string name, decimal salary, int teamSize) : base(name, salary) => TeamSize = teamSize;

    public override string Describe() => $"Manager: {FullName}, salario: {Salary:C0}, equipo: {TeamSize} personas";
}

// Contratista no puede heredarse más (sealed)
public sealed class Contractor : Person
{
    public decimal HourRate { get; }
    public Contractor(string name, decimal hourRate) : base(name) => HourRate = hourRate;

    public override string Describe() => $"Contratista: {FullName}, paga por hora: {HourRate:C0}";
}

/* Ejercicio 2
   Crea Manager : EmployeeFullTime con propiedad TeamSize.
   Override Describe() para incluir tamaño de equipo.
   Instancia Person, EmployeeFullTime, Manager, Contractor y llama Describe().
*/
