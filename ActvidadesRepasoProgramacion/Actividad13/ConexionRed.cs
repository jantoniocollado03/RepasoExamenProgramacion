namespace Actividad13;

public class ConexionRed : IDisposable
{ 
    public void Dispose()
    {
        Console.WriteLine("Sesión cerrada y recursos liberados");
        GC.SuppressFinalize(this);
    }
}