class AccesoData  // crea una clase llamada AccesoData
{
    public List<Evento> obtenerListaEventos() // define un método público llamado obtenerListaEventos que devuelve una lista de objetos Evento
    {
        List<Evento> eventos = new List<Evento>(); // crea una nueva lista de objetos Evento llamada eventos
        TipoEvento cultural = new TipoEvento("Cultural"); // crea nuevas instancias de la clase TipoEvento con diferentes nombres
        TipoEvento deportivo = new TipoEvento("Deportivo"); // crea un objeto TipoEvento llamado deportivo con el valor "Deportivo"
        TipoEvento exhibicion = new TipoEvento("Exhibición"); // crea un objeto TipoEvento llamado exhibicion con el valor "Exhibición"
        TipoEvento feria = new TipoEvento("Feria"); // crea un objeto TipoEvento llamado feria con el valor "Feria"
        
        Evento eventoUno = new Evento("Evento uno", cultural, true); // crea nuevas instancias de la clase Evento con diferentes nombres, tipos y valores booleanos
        Evento eventoDos = new Evento("Evento dos", deportivo, false); // crea un objeto Evento llamado eventoDos con el valor "Evento dos", tipo deportivo y soloAdultos en false
        Evento eventoTres = new Evento("Evento tres", deportivo, true); // crea un objeto Evento llamado eventoTres con el valor "Evento tres", tipo deportivo y soloAdultos en true
        Evento eventoCuatro = new Evento("Evento cuatro", feria, false); // crea un objeto Evento llamado eventoCuatro con el valor "Evento cuatro", tipo feria y soloAdultos en false
        Evento eventoCinco = new Evento("Evento cinco", feria, true); // crea un objeto Evento llamado eventoCinco con el valor "Evento cinco", tipo feria y soloAdultos en true
        Evento eventoSeis = new Evento("Evento seis", exhibicion, true); // crea un objeto Evento llamado eventoSeis con el valor "Evento seis", tipo exhibicion y soloAdultos en true

        eventos.Add(eventoUno); // agrega los objetos Evento creados anteriormente a la lista eventos
        eventos.Add(eventoDos); // agrega el objeto eventoDos a la lista eventos
        eventos.Add(eventoTres); // agrega el objeto eventoTres a la lista eventos
        eventos.Add(eventoCuatro); // agrega el objeto eventoCuatro a la lista eventos
        eventos.Add(eventoCinco); // agrega el objeto eventoCinco a la lista eventos
        eventos.Add(eventoSeis); // agrega el objeto eventoSeis a la lista eventos
        return eventos; // devuelve la lista eventos que contiene todos los objetos Evento agregados
    }
}