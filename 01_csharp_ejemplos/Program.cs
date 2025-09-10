using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ejercicio 1 - Productos");
            Console.WriteLine("2. Ejercicio 2 - Personas y empleados");
            Console.WriteLine("3. Ejercicio 3 - Reportes");
            Console.WriteLine("4. Ejercicio 4 - Nómina");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    break;
                case "2":
                    Ejercicio2();
                    break;
                case "3":
                    Ejercicio3();
                    break;
                case "4":
                    Ejercicio4();
                    break;
                case "0":
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    continue;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
            Console.ReadKey();
        }
    }

    static void Ejercicio1()
    {
        Console.WriteLine("=== Ejercicio 1 ===");
        var p1 = new Product(1, "Laptop", 3_500_000m, 10);
        var p2 = new Product(2, "Mouse", 50);
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }

    static void Ejercicio2()
    {
        Console.WriteLine("=== Ejercicio 2 ===");
        var per = new Person("Juan");
        var emp = new EmployeeFullTime("Ana", 4_200_000m);
        var man = new Manager("Carlos", 8_000_000m, 5);
        var con = new Contractor("Luis", 80_000m);
        Console.WriteLine(per.Describe());
        Console.WriteLine(emp.Describe());
        Console.WriteLine(man.Describe());
        Console.WriteLine(con.Describe());
    }

    static void Ejercicio3()
    {
        Console.WriteLine("=== Ejercicio 3 ===");
        var reportList = new List<IReportable>
        {
            new FullTime("Pedro", 3_500_000m),
            new Hourly("María", 60_000m, 100)
        };
        foreach (var r in reportList)
            Console.WriteLine(r.BuildReport());
    }

    static void Ejercicio4()
    {
        Console.WriteLine("=== Ejercicio 4 ===");
        var payroll = new List<IPayable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 180)
        };

        var service = new PayrollService(new OvertimeCalculator(), new ConsoleOutput());
        service.Run(payroll);

        var fileService = new PayrollService(new OvertimeCalculator(), new FileOutput("payroll.txt"));
        fileService.Run(payroll);
        Console.WriteLine("Se generó el archivo payroll.txt con resultados.");
    }
}
