namespace ConsoleApp05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int cantidadNumeros = 0;
            int mayorNumero = int.MinValue;
            int cantidadPares = 0;

            while (suma <= 60)
            {
                int numero = PedirNumero("Ingrese un número: ");
                suma += numero;
                cantidadNumeros++;

                mayorNumero = ObtenerMayor(mayorNumero, numero);

                cantidadPares = ContarPares(cantidadPares, numero);
            }

            MostrarInformacion(suma, cantidadNumeros, mayorNumero, cantidadPares);
        }
        static int ObtenerMayor(int mayorNumero, int numero)
        {
            return Math.Max(mayorNumero, numero);
        }

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        static int ContarPares(int cantidadPares, int numero)
        {
            if (EsPar(numero))
            {
                cantidadPares++;
            }

            return cantidadPares;
        }

        private static void MostrarInformacion(int suma, int cantidadNumeros, int mayorNumero, int cantidadPares)
        {
            Console.WriteLine($"Se ingresaron {cantidadNumeros} números.");
            Console.WriteLine($"La suma total es: {suma}.");
            Console.WriteLine($"El mayor número ingresado es: {mayorNumero}.");
            Console.WriteLine($"La cantidad de números pares es: {cantidadPares}.");
        }

        static int PedirNumero(string mensaje)
        {
            int numero;
            bool esNumeroValido;

            do
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out numero);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            } while (!esNumeroValido);

            return numero;
        }
    }
}
