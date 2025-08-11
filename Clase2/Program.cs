// See https://aka.ms/new-console-template for more information


// 

/*  Ejercicio 1
Console.WriteLine("Ingrese el nombre del producto:");
string producto = Console.ReadLine(); 
int precio = 0;
switch (producto.ToLower())
{
    case "televisor":
        precio = 300;
        Console.WriteLine($"El precio del televisor es ${precio}.00");
        break;
    case "celular":
        precio = 200;
        Console.WriteLine($"El precio del celular es ${precio}.00");
        break;
    case "computador":
        precio = 500;
        Console.WriteLine($"El precio del computador es ${precio}.00");
        break;
    default:
        Console.WriteLine("Producto no encontrado.");
        break;
} */

/*  // Ejercicio 2
Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Mostrar fecha");
Console.WriteLine("2. Mostrar nombre");
Console.WriteLine("3. Mostrar mensaje motivador");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"La fecha de hoy es: {DateTime.Now.ToShortDateString()}");
        break;
    case 2:
        Console.WriteLine("Mi nombre es: Jonathan");
        break;
    case 3:
        Console.WriteLine("¡Sigue adelante, no te rindas!");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
} */

/*  // Ejercicio 3

Console.WriteLine("Ingrese el valor del valgo de rodilla (en grados):");
double valgoRodilla = Convert.ToDouble(Console.ReadLine());
if (valgoRodilla < 10)
{
    Console.WriteLine("Valgo de rodilla normal.");
}
else if (valgoRodilla >= 10 && valgoRodilla < 20)
{
    Console.WriteLine("Valgo de rodilla leve.");
}
else if (valgoRodilla >= 20 && valgoRodilla < 30)
{
    Console.WriteLine("Valgo de rodilla moderado.");
}
else
{
    Console.WriteLine("Valgo de rodilla severo.");
} */

/* // Ejercisio 4


Console.WriteLine("Bienvenido al sistema bancario");
double saldo = 500000;
bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Retirar dinero");
    Console.WriteLine("3. Depositar dinero");
    Console.WriteLine("4. Salir");
    
    Console.WriteLine();
    


    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("*----------------------------*");
            Console.WriteLine($"Su saldo actual es: ${saldo}");
             Console.WriteLine("*----------------------------*");
            break;
        case 2:
            Console.WriteLine("Ingrese el monto a retirar:");
            double montoRetiro = Convert.ToDouble(Console.ReadLine());
            if (montoRetiro <= saldo)
            {
                saldo -= montoRetiro;
                Console.WriteLine("*---------------------------------------------*");
                Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: ${saldo}");
                Console.WriteLine("*----------------------------------------------*");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
            }
            break;
        case 4:
            salir = true;
            Console.WriteLine("Gracias por usar nuestro sistema. ¡Hasta luego!");
            break;

        case 3:

            Console.WriteLine("Ingrese el monto a depositar:");
            double montoDeposito = Convert.ToDouble(Console.ReadLine());
            saldo += montoDeposito;
            Console.WriteLine("*------------------------------------------------------*");
            Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: ${saldo}");
            Console.WriteLine("*-------------------------------------------------------*");
            break;

        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }
}*/

