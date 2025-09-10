public class Motocicleta : Vehiculo
{
    //propiedades (atributos)

    public Boolean Manubrio { get; set; }

    //metodos (funciones)

    public void RecojerPasajero()
    {
        Console.WriteLine("La motocicleta esta recogiendo un pasajero");
    }
}