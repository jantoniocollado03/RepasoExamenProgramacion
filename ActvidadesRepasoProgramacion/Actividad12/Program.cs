
var sensor = new SensorSeguridad();

sensor.AlarmaDisparada += (s, a) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(a.Motivo);
    Console.ResetColor();
};
    
public class AlarmaEventArgs : EventArgs
{
    public string Motivo{get;}
    public AlarmaEventArgs(string motivo)=> Motivo = motivo;
}

public class SensorSeguridad
{
    public EventHandler<AlarmaEventArgs> AlarmaDisparada;

    public void DetectarMovimiento()
    {
        AlarmaDisparada?.Invoke(this, new AlarmaEventArgs("Movimiento detectado"));
    }
}