
using System.ComponentModel;
using Actividad4;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = [1, 3, 7, 10, 20];

            var r = BuscadorAvanzado.Filtrar(lista, x => x > 10);

            r = [20];
        }
    }
}