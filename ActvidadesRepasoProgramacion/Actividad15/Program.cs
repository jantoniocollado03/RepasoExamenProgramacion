
var alumno = new List<Alumno>();

alumno.Add(new Alumno{Nombre = "Frasquito", Clase = "1A", NotaMedia = 5});
alumno.Add(new Alumno{Nombre = "Julián", Clase = "1B", NotaMedia = 3});

var todos = alumno.All(x=>x.NotaMedia>=5);

var matricula = alumno.All(x=>x.NotaMedia==10);

var grupos = alumno.GroupBy(x=>x.Clase).ToList();


public class Alumno
{
    public string Nombre { get; set; }
    public string Clase { get; set; }
    public double NotaMedia { get; set; }
}