
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void ValidarMatricula(string matricula)
        {
            try
            {
                Debug.Assert(matricula != null, "La entrada no puede ser null");


                bool esValido = !Regex.IsMatch(matricula,@"^\d{4}[B-DF-HJ-NP-TV-Z]{3}$");
                
                if (esValido)
                {
                    throw new ArgumentException(nameof(matricula),$"La entrada no puede ser valido");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);               
            }
            finally{}

        }
    }
    
    
}

