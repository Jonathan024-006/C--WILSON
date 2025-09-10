using System;
using POOWorkshop.Domain.Payroll;

namespace POOWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Nómina (POO) ===\n");

            // Crear empleados de prueba
            EmployeeBase hourlyEmployee = new Hourly("Pedro", 50, 40);
            EmployeeBase fullTimeEmployee = new FullTime("María", 3000);

            // Mostrar reportes usando polimorfismo
            Console.WriteLine(hourlyEmployee.BuildReport());
            Console.WriteLine(fullTimeEmployee.BuildReport());

            Console.WriteLine("\n=== Fin del Programa ===");
        }
    }
}
