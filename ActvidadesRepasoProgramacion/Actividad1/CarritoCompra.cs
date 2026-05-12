namespace Actividad1;

public class CarritoCompra
{
    private readonly IProcesarPagos _procesarPagos;

    public CarritoCompra(IProcesarPagos procesarPagos)
    {
        this._procesarPagos = procesarPagos;
    }

    public void Procesar()
    {
        _procesarPagos.Procesar(cantidad:1000);
    }
}