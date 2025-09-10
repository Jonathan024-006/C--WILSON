abstract class Persona  //1 // crea una clase abstracta llamada persona 
{
    public string Nombre { get; set; } // crea un propiedad tipo publica que recibe valores string llamada Nombre
    public int Edad { get; set; } // crea una propiedad tipo publica que recibe valores enteros llamada Edad

    public Persona(string nombre, int edad) // define un constructor público que toma dos parámetros: un string llamado nombre y un entero llamado edad
    {
        this.Nombre = nombre; // asigna el valor del parámetro nombre a la propiedad Nombre de la clase
        this.Edad = edad; // asigna el valor del parámetro edad a la propiedad Edad de la clase
    }
}