namespace Actividad1;

public class PagoPayPal : IProcesarPagos
{
    public bool Procesar(decimal cantidad)
    {
        return true;
    }
}