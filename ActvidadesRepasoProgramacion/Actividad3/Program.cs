
namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordenadas1 = new CoordenadaGPS(0, 1);
            var coordenadas2 = new CoordenadaGPS(0, 1);
            
            var pedido1 = new Pedido();
            pedido1.Id = 0;
            var pedido2 = new Pedido();
            pedido2.Id = 0;

            var usuario1 = new Usuario("pepico@gmail.es");
            var usuario2 = new Usuario("pepico@gmail.es");
            
            Console.WriteLine(coordenadas1 == coordenadas2);
            
            Console.WriteLine(usuario1 == usuario2);
            
            Console.WriteLine(pedido1 == pedido2);
        }
    }
}