/* Console.WriteLine("Hello, World!");

//programacion estructurada
// ejemplo de manejo de variables

// sintaxis de variables
//tipoDatoAlmacenar nombreVariable = valor;
//tipo de datos primitivos 

int edad = 30; // entero
Console.WriteLine($"Edad: {edad} años");

string nombreJ = "Juan"; // cadena de texto
Console.WriteLine($"Nombre: {nombreJ}");
char inicial = 'J'; // caracter 
//boleano
bool esEstudiante = true; // booleano
Console.WriteLine($"Es estudiante: {esEstudiante}");
// tipo de dato numerico
float altura = 1.75f; // flotante
double peso = 70.5; // doble precision
decimal salario = 1500.50m; // decimal
Console.WriteLine($"Altura: {altura} m, Peso: {peso} kg, Salario: {salario} $");
//tipo de datos fecha
DateTime fechaNacimiento = new DateTime(1993, 5, 15); // fecha
DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now); // fecha sin hora

//operacions con variables 
int suma = edad + 5; // suma
Console.WriteLine($"Suma de edad + 5: {suma}");

//sumar dos enteros
int numero1 = 10;
int numero2 = 20;
int resultadoSuma = numero1 + numero2; // suma
Console.WriteLine($"Resultado de la suma: {resultadoSuma}");

//Ejemplo sumar dos numeros con variables
int a = Convert.ToInt32(Console.ReadLine()); // entrada de datos
int b = int.Parse(Console.ReadLine(
    
)); // entrada de datos
int resultado = a + b; // suma
Console.WriteLine($"Resultado de la suma de a + b: {resultado}");



// 
        // EJERCICIO 1
        // 

        // Solicita el nombre del usuario
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Solicita la cantidad de pesos colombianos
        Console.Write("Hola " + nombre + ", ingrese la cantidad de pesos colombianos: ");
        string entrada = Console.ReadLine();
        double cantidadPesos;

        // Verifica si la entrada es un número válido
        if (double.TryParse(entrada, out cantidadPesos))
        {
            // Verifica si la cantidad es mayor que cero
            if (cantidadPesos > 0)
            {
                Console.WriteLine($"Gracias, {nombre}. Usted ingresó {cantidadPesos} pesos colombianos.");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
            }
        }
        else
        {
            Console.WriteLine("Error: debe ingresar un valor numérico válido.");
        }

        // Espera a que el usuario presione una tecla antes de salir
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    

     // 
        // EJERCICIO 2
        // 

        // Solicita al usuario la cantidad de pesos colombianos a convertir
        Console.Write("Ingrese la cantidad de pesos colombianos que desea convertir: ");
        string entrada2 = Console.ReadLine();
        double pesosColombianos;

        // Verifica si la entrada es numérica
        if (double.TryParse(entrada, out pesosColombianos))
        {
            // Verifica que sea mayor a cero
            if (pesosColombianos > 0)
            {
                // Tasas de cambio aproximadas
                double tasaUSD = 4000;   // 1 USD = 4000 COP
                double tasaEUR = 4400;   // 1 EUR = 4400 COP
                double tasaPEN = 1100;   // 1 PEN = 1100 COP

                // Conversiones
                double enDolares = pesosColombianos / tasaUSD;
                double enEuros = pesosColombianos / tasaEUR;
                double enSoles = pesosColombianos / tasaPEN;

                // Muestra los resultados
                Console.WriteLine("\nConversión de moneda:");
                Console.WriteLine($"- Dólares (USD): {enDolares:F2}");
                Console.WriteLine($"- Euros (EUR): {enEuros:F2}");
                Console.WriteLine($"- Soles peruanos (PEN): {enSoles:F2}");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar solo números.");
        }

        // Espera a que el usuario presione una tecla para cerrar
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey(); */