
namespace Actividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        
        public async Task CopiarLogAsync()
        {
            var rutaOrigen = Path.Combine(System.Environment.CurrentDirectory, "josepoco1.txt");
            
            await using FileStream fs = new FileStream(rutaOrigen, FileMode.Open, FileAccess.Read) ;
        }
    }
}