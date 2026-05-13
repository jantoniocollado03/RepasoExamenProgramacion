
namespace Actividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        
        public async Task CopiarLogAsync()
        {
            try
            {
                using FileStream fso = new FileStream("archivoilog.txt", FileMode.Open);
                using FileStream fsd = new FileStream("copia.txt", FileMode.Create);

                await fso.CopyToAsync(fsd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}