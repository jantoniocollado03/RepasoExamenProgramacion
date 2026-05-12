
using Actividad5;

List<Transaccion> lista = new List<Transaccion>();

lista.Add(new Transaccion{Categoria = "Chocolate", Monto = 15.99, Fecha = new DateTime(2020, 1, 1)});
lista.Add(new Transaccion());
lista.Add(new Transaccion());

var consulta = lista.Where(x=>x.Fecha.Year==DateTime.Now.Year).GroupBy(x=>x.Categoria).Select(grupo=>new {Categoria = grupo.Key, Transacciones = grupo.Count()});

foreach (var item in consulta.ToList())
{
    Console.WriteLine($"{item.Categoria} - {item.Transacciones}");
}
