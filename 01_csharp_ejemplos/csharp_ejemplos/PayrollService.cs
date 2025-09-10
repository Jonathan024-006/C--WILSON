using System;
using System.Collections.Generic;
using System.IO;

// Interfaces
public interface IPayable { decimal CalculatePayment(); } // crea una interfaz llamada IPayable que declara un método CalculatePayment que devuelve un valor decimal
public interface IPaymentCalculator { decimal Calc(IPayable e); } // crea una interfaz llamada IPaymentCalculator que declara un método Calc que toma un parámetro de tipo IPayable y devuelve un valor decimal
public interface IOutput { void WriteLine(string text); } // crea una interfaz llamada IOutput que declara un método WriteLine que toma un parámetro de tipo string y no devuelve ningún valor

// Calculadora normal
public class DefaultPaymentCalculator : IPaymentCalculator // crea una clase llamada DefaultPaymentCalculator que implementa la interfaz IPaymentCalculator
{
    public decimal Calc(IPayable e) => e.CalculatePayment(); // implementa el método Calc de la interfaz IPaymentCalculator que llama al método CalculatePayment del objeto IPayable pasado como parámetro y devuelve su resultado
}

// Salida en consola
public class ConsoleOutput : IOutput // crea una clase llamada ConsoleOutput que implementa la interfaz IOutput
{
    public void WriteLine(string t) => Console.WriteLine(t); // implementa el método WriteLine de la interfaz IOutput que escribe el texto pasado como parámetro en la consola
}

// Salida en archivo
public class FileOutput : IOutput // crea una clase llamada FileOutput que implementa la interfaz IOutput
{
    private readonly string _path; // declara un campo privado de solo lectura llamado _path de tipo string
    public FileOutput(string path) => _path = path; // define un constructor público que toma un parámetro string llamado path y asigna su valor al campo _path

    public void WriteLine(string text) // implementa el método WriteLine de la interfaz IOutput que escribe el texto pasado como parámetro en un archivo especificado por _path, agregando una nueva línea al final
    {
        File.AppendAllText(_path, text + Environment.NewLine); // usa el método estático AppendAllText de la clase File para agregar el texto al archivo, creando el archivo si no existe
    }
}

// Calculadora con horas extra
public class OvertimeCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e)
    {
        if (e is Hourly h)
        {
            var normalPay = h.CalculatePayment();
            var overtime = h.Hours > 160 ? (h.Hours - 160) * h.Rate * 0.5m : 0;
            return normalPay + overtime;
        }
        return e.CalculatePayment();
    }
}

// Servicio de nómina
public class PayrollService
{
    private readonly IPaymentCalculator _calc;
    private readonly IOutput _out;

    public PayrollService(IPaymentCalculator calc, IOutput output)
    {
        _calc = calc;
        _out = output;
    }

    public void Run(IEnumerable<IPayable> items)
    {
        foreach (var it in items)
            _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
    }
}

/* Ejercicio 4
   Implementa FileOutput : IOutput que escriba a un .txt.
   Crea OvertimeCalculator : IPaymentCalculator que agregue horas extra a Hourly.
   Inyecta ambas en PayrollService y ejecuta.
*/
