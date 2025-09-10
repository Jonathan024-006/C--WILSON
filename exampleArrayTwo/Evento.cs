class Evento  // crea una clase llamada Evento
{
    public static int numeroDeEventos = 0; // declara un campo estático público llamado numeroDeEventos de tipo entero e inicializado en 0
    public string NombreEvento { get; set; } // crea una propiedad tipo publica que recibe valores string llamada NombreEvento
    public TipoEvento Tipo { get; set; } // crea una propiedad tipo publica que recibe valores TipoEvento llamada Tipo
    public bool SoloAdultos { get; set; } // crea una propiedad tipo publica que recibe valores booleanos llamada SoloAdultos

    public Evento(string nombreEvento, TipoEvento tipo, bool soloAdultos) // define un constructor público que toma tres parámetros: un string llamado nombreEvento, un TipoEvento llamado tipo y un booleano llamado soloAdultos
    {
        this.NombreEvento = nombreEvento; // asigna el valor del parámetro nombreEvento a la propiedad NombreEvento de la clase
        this.Tipo = tipo; // asigna el valor del parámetro tipo a la propiedad Tipo de la clase
        this.SoloAdultos = soloAdultos; // asigna el valor del parámetro soloAdultos a la propiedad SoloAdultos de la clase
        numeroDeEventos++; // incrementa el campo estático numeroDeEventos en 1 cada vez que se crea una nueva instancia de la clase Evento
    }
}