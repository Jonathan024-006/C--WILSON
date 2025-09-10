internal class TipoEvento  // crea una clase llamada TipoEvento con un modificador de acceso internal el cual sirve para que la clase solo sea accesible dentro del mismo ensamblado
{
    private string nombre; // declara un campo privado llamado nombre de tipo string

    public TipoEvento(string nombre) // define un constructor público que toma un parámetro string llamado nombre
    {
        this.nombre = nombre; // asigna el valor del parámetro nombre al campo privado nombre de la clase
    }
}