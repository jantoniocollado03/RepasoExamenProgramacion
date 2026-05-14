namespace Actividad11
{
    class Program
    {
        public static (int Maximo, int Minimo, double Media) AnalizarArray(int[] numero)
        {
            if (numero.Length == 0)
            {
                int maximo = numero[0];
                int minimo = numero[0];
                double suma = 0;
                
                foreach (var n in numero)
                {
                    if (n > maximo)
                    {
                        maximo = n;
                    }

                    if (n < minimo)
                    {
                        minimo = n;
                    }
                    suma += n;
                }
            
                return (maximo, minimo, suma/numero.Length);
            }
            else
            {
                return (0, 0 ,0);
            }
        }

        private int[] num = [10, -20, 30, 0, 0, 100, -75];
        (int max, int min, double media) = AnalizarArray(numero);
        
    }
}