
namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrito = new CarritoCompra(new PagoPayPal());
            var carrito2 = new CarritoCompra(new PagoTarjeta());
        }
    }
}