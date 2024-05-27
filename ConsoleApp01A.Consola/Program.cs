namespace ConsoleApp01A.Consola
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
                int numero = LeerNumero();
                suma += numero;

                cantidadPares = ContarPares(cantidadPares, numero);

                cantidadMayoresDiez = ContarMayoresQueDiez(cantidadMayoresDiez, numero);
            }

            double promedio = GetPromedio(suma);

            MostrarResultados(suma, cantidadPares, cantidadMayoresDiez, promedio);

        }

        private static void MostrarResultados(int suma, int cantidadPares, int cantidadMayoresDiez, double promedio)
        {
            Console.WriteLine($"Suma de los números: {suma}");
            Console.WriteLine($"Promedio de los números: {promedio}");
            Console.WriteLine($"Cantidad de números pares: {cantidadPares}");
            Console.WriteLine($"Cantidad de números mayores a 10: {cantidadMayoresDiez}");
        }

        static int ContarPares(int cantidadPares, int numero) => EsPar(numero) ? cantidadPares++ : cantidadPares;

        static int ContarMayoresQueDiez(int cantidadMayoresDiez, int numero)=>    

             numero>10?cantidadMayoresDiez++:cantidadMayoresDiez;
        

        static double GetPromedio(int suma) => suma / 10.0;

        static int LeerNumero()
        {
            int numero;
            bool esNumeroValido;

            do
            {
                string? entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out numero);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            } while (!esNumeroValido);

            return numero;
        }
        static bool EsPar(int numero) => numero % 2 == 0;
    }
}
