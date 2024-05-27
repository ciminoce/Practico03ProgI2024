namespace ConsoleApp09.Consola
{
    class Program
    {
        static void Main()
        {
            int numero = PedirNumero("Ingrese un número entero: ");

            bool esPar = EsPar(numero);
            bool esPrimo = EsPrimo(numero);
            bool esPerfecto = EsPerfecto(numero);

            Console.WriteLine($"El número {numero} es {(esPar ? "par" : "impar")}.");
            Console.WriteLine($"El número {numero} {(esPrimo ? "es primo" : "no es primo")}.");
            Console.WriteLine($"El número {numero} {(esPerfecto ? "es perfecto" : "no es perfecto")}.");
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

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool EsPerfecto(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            int sumaDivisores = 0;

            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
    }
}
