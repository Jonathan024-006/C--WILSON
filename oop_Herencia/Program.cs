Console.WriteLine("concesionario SMC");

Console.WriteLine("tipo de vehiculo? 1) taxi o 2) motocicleta");
short tipoVehiculo = short.Parse(Console.ReadLine());

Console.WriteLine("marca:");
string marca = Console.ReadLine();

Console.WriteLine("linea:");
string linea = Console.ReadLine();

Console.WriteLine("modelo:");
short modelo = short.Parse(Console.ReadLine());

Console.WriteLine("placa:");
string placa = Console.ReadLine();

// vehiculo Vehiculo_uno = new Vehiculo () { Marca = marca, Linea = linea};

Taxi taxi1 = new Taxi() { Modelo = modelo };

Motocicleta moto = new Motocicleta() { Placa = placa };

if (tipoVehiculo == 1)
{
    // Es un taxi
    Console.WriteLine("Taxi creado:");
    Console.WriteLine($"Marca: {marca}");
    Console.WriteLine($"Linea: {linea}");
    Console.WriteLine($"Modelo: {modelo}");
    taxi1.RecojerPasajero();
}
else if (tipoVehiculo == 2)
{
    // Es una motocicleta
    Console.WriteLine("Motocicleta creada:");
    Console.WriteLine($"Marca: {marca}");
    Console.WriteLine($"Linea: {linea}");
    Console.WriteLine($"Placa: {placa}");
    moto.RecojerPasajero();
}