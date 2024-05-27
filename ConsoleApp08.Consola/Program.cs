namespace ConsoleApp08.Consola
{
    using System;

    class Program
    {
        static void Main()
        {
            int numero = PedirNumeroMayorA100();

            int cantidadDigitos = ContarDigitos(numero);
            int menorDigito = ObtenerMenorDigito(numero);
            bool esCapicua = EsCapicua(numero);

            Console.WriteLine($"El número tiene {cantidadDigitos} dígitos.");
            Console.WriteLine($"El menor dígito del número es: {menorDigito}");
            Console.WriteLine($"¿El número es capicúa? {(esCapicua ? "Sí" : "No")}");
        }

        static int PedirNumeroMayorA100()
        {
            int numero;
            bool esNumeroValido;

            do
            {
                Console.Write("Ingrese un número entero mayor a 100: ");
                string? entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out numero) && numero > 100;

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero mayor a 100.");
                }
            } while (!esNumeroValido);

            return numero;
        }

        static int ContarDigitos(int numero)
        {
            return numero.ToString().Length;
        }

        static int ObtenerMenorDigito(int numero)
        {
            int menorDigito = 9;

            while (numero > 0)
            {
                int digito = numero % 10;
                if (digito < menorDigito)
                {
                    menorDigito = digito;
                }
                numero /= 10;
            }

            return menorDigito;
        }

        static bool EsCapicua(int numero)
        {
            string numeroStr = numero.ToString();
            char[] numeroArr = numeroStr.ToCharArray();
            Array.Reverse(numeroArr);
            string numeroReverso = new string(numeroArr);

            return numeroStr == numeroReverso;
        }
    }
}
