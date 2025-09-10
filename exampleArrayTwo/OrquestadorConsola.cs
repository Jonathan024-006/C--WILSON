static class OrquestadorConsola // crea una clase estática llamada OrquestadorConsola
{
    private static List<Persona> personas = new List<Persona>(); // crea una lista estática privada llamada personas que almacena objetos de tipo Persona

    public static void solicitarDatosPersonas() // crea un método estático público llamado solicitarDatosPersonas
    {
        int opcion = -1; // declara una variable entera llamada opcion e inicialízala con -1
        do // inicia un bucle do-while que se ejecuta al menos una vez y continúa mientras opcion sea diferente de 0
        {
            Console.WriteLine("Acá puede inscribir las personas para saber a cuales eventos pueden asistir."); // muestra un mensaje en la consola
            Console.WriteLine("Si desea inscribir una persona digite un número diferente al 0. Si desea salir digite el número 0");
            opcion = Int32.Parse(Console.ReadLine()); // lee una línea de la consola, la convierte a entero y la asigna a opcion
            if (opcion != 0)
            {
                Console.WriteLine("Por favor digite el nombre completo de la persona (presione enter) y la edad (presione enter)");
                string nombre = Console.ReadLine(); // lee una línea de la consola y la asigna a una variable string llamada nombre
                int edad = Int32.Parse(Console.ReadLine()); // lee una línea de la consola, la convierte a entero y la asigna a una variable entera llamada edad
                Persona persona;
                if (edad < 18) // si la edad es menor que 18
                {
                    persona = new Ninno(nombre, edad); // crea una instancia de la clase Ninno con el nombre y la edad proporcionados y la asigna a la variable persona

                }
                else // si la edad es 18 o mayor
                {
                    persona = new Adulto(nombre, edad); // crea una instancia de la clase Adulto con el nombre y la edad proporcionados y la asigna a la variable persona
                }
                personas.Add(persona); // agrega la persona creada a la lista personas
            }


        } while (opcion != 0); // continúa el bucle mientras opcion sea diferente de 0
        imprimirPersonas(); // llama al método imprimirPersonas para mostrar un resumen de las personas registradas
    }

    public static void imprimirPersonas() // crea un método estático público llamado imprimirPersonas
    {
        Console.WriteLine("La cantidad de personas registradas es:" + personas.Count); // muestra en la consola la cantidad de personas registradas en la lista personas
        int numeroNinnos = 0;
        int numeroAdultos = 0;

        foreach (Persona persona in personas) // recorre cada persona en la lista personas
        {
            if (persona is Ninno) // si la persona es de tipo Ninno
            {
                numeroNinnos++; // incrementa el contador de niños
            }
            else
            {
                numeroAdultos++; // incrementa el contador de adultos
            }
        }

        Console.WriteLine("La cantidad de niños registrados es: " + numeroNinnos); // muestra en la consola la cantidad de niños registrados
        Console.WriteLine("La cantidad de adultos registrados es: " + numeroAdultos); // muestra en la consola la cantidad de adultos registrados
    }

    public static void imprimirEventos(List<Evento> eventos) // crea un método estático público llamado imprimirEventos que toma una lista de eventos como parámetro
    {
        foreach (Evento evento in eventos) // recorre cada evento en la lista de eventos
        {
            string variante = evento.SoloAdultos ? "no" : "si"; // si el evento es solo para adultos, asigna "no" a la variable variante; de lo contrario, asigna "si"
            Console.WriteLine("En el evento: " + evento.NombreEvento + " " + variante + " pueden asistir niños"); // muestra en la consola el nombre del evento y si los niños pueden asistir o no
            if (evento.SoloAdultos) // si el evento es solo para adultos
            {
                Console.WriteLine("Es decir las siguientes personas podrán asistir:");
                foreach (Persona persona in personas) // recorre cada persona en la lista personas
                {
                    if (persona is Adulto) // si la persona es de tipo Adulto
                    {
                        Console.WriteLine(persona.Nombre); // muestra en la consola el nombre de la persona
                    }
                }
            }
            else // si el evento permite la asistencia de niños
            {
                Console.WriteLine("Es decir las siguientes personas no podrán asistir:");// muestra en la consola un mensaje indicando que se mostrarán las personas que no podrán asistir
                foreach (Persona persona in personas) // recorre cada persona en la lista personas
                {
                    if (persona is Ninno) // si la persona es de tipo Ninno
                    {
                        Console.WriteLine(persona.Nombre); // muestra en la consola el nombre de la persona
                    }
                }
            }


        }
    }

}