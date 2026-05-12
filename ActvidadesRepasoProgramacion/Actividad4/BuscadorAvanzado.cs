using Actividad4;
namespace Actividad4;

public static class BuscadorAvanzado
{
    public static List<T>Filtrar<T>(List<T> datos, Func<T, bool> predicado)
    {
        List<T> resultado = new List<T>();
        foreach (T item in datos)
        {
            if (predicado(item))
            {
                resultado.Add(item);
            }
        }
        return resultado;
    }
}