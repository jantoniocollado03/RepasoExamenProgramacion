
var usuario = new Dictionary<int, string>();

usuario[1] = "Uno";
usuario[2] = "Dos";

try
{
    string nombre = usuario[99];

}
catch (KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

if (usuario.TryGetValue(99, out string nombre))
{
    Console.WriteLine(nombre);
}



