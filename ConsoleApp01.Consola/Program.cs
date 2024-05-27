namespace ConsoleApp01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int cantidadPares = 0;
            int cantidadMayoresDiez = 0;

            Console.WriteLine("Ingrese 10 números:");

            for (int i = 1; i <= 10; i++)
            {
                int numero;
                bool esNumeroValido;

                do
                {
                    Console.Write($"Número {i}: ");
                    string? entrada = Console.ReadLine();
                    esNumeroValido = int.TryParse(entrada, out numero);

                    if (!esNumeroValido)
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                    }
                } while (!esNumeroValido);

                suma += numero;

                if (numero % 2 == 0)
                {
                    cantidadPares++;
                }

                if (numero > 10)
                {
                    cantidadMayoresDiez++;
                }
            }

            double promedio = suma / 10.0;

            Console.WriteLine($"Suma de los números: {suma}");
            Console.WriteLine($"Promedio de los números: {promedio}");
            Console.WriteLine($"Cantidad de números pares: {cantidadPares}");
            Console.WriteLine($"Cantidad de números mayores a 10: {cantidadMayoresDiez}");
        }
    }
}
