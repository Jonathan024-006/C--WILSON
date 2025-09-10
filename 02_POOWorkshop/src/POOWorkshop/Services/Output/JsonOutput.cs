using System.Text.Json;

namespace POOWorkshop.Services.Output
{
    public class JsonOutput : IOutput
    {
        public void WriteLine(string message)
        {
            // Convierte el mensaje a JSON
            string json = JsonSerializer.Serialize(new { Mensaje = message });
            Console.WriteLine(json);
        }
    }
}
