namespace ConsoleApp06.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int cantidadNumeros = 0;

            while (suma <= 500)
            {
                int numero = Azar(1,100); // Genera un número aleatorio entre 1 y 100
                Console.WriteLine($"Número Generado: {numero}");
                suma += numero;
                cantidadNumeros++;
            }

            Console.WriteLine($"La suma de los números generados es: {suma}");
            Console.WriteLine($"La cantidad de números generados es: {cantidadNumeros}");
        }

        static int Azar(int x, int y)
        {
            Random rnd = new Random();
            return rnd.Next(x,y+1);
        }
    }
}
