class Taxi : Vehiculo
{
    //propiedades (atributos)

    public string Banderazo { get; set; }
    public short Flota { get; set; }

    //metodos (funciones)

    public void RecojerPasajero()
    {
        Console.WriteLine("El taxi esta recogiendo un pasajero");
    }

}