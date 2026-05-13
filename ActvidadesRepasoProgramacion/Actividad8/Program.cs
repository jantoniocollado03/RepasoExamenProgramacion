
using System.Text.Json;

namespace Actividad8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var PerfilUsusario =  new PerfilUsuario{Username = "a", Email = "a@a.es", TokenSesion = "ABCD"};
                
                string Json = JsonSerializer.Serialize(PerfilUsusario, new JsonSerializerOptions{WriteIndented = true});
                
                File.WriteAllText("PerfilUsusario.json", Json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        
    }
}