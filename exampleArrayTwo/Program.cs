// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

AccesoData data = new AccesoData(); // crea una instancia de la clase AccesoData llamada data
List<Evento> eventos = data.obtenerListaEventos(); // llama al método obtenerListaEventos de la instancia data y almacena el resultado en una lista de eventos llamada eventos

OrquestadorConsola.solicitarDatosPersonas(); // llama al método solicitarDatosPersonas de la clase OrquestadorConsola
OrquestadorConsola.imprimirEventos(eventos); // llama al método imprimirEventos de la clase OrquestadorConsola pasando la lista eventos como argumento
