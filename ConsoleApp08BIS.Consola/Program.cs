namespace ConsoleApp08BIS.Consola
{

    class Program
    {
        static void Main()
        {
            int numero = PedirNumeroMayorA100();

            int cantidadDigitos = ContarDigitos(numero);
            int menorDigito = ObtenerMenorDigito(numero);
            bool esCapicua = EsCapicua(numero);
            int sumaDigitos = SumarDigitos(numero);
            int numeroInvertido = InvertirNumero(numero);
            int[] frecuenciaDigitos = ContarFrecuenciaDigitos(numero);

            Console.WriteLine($"El número tiene {cantidadDigitos} dígitos.");
            Console.WriteLine($"El menor dígito del número es: {menorDigito}");
            Console.WriteLine($"¿El número es capicúa? {(esCapicua ? "Sí" : "No")}");
            Console.WriteLine($"La suma de los dígitos es: {sumaDigitos}");
            Console.WriteLine($"El número invertido es: {numeroInvertido}");
            Console.WriteLine("Frecuencia de cada dígito:");
            for (int i = 0; i < frecuenciaDigitos.Length; i++)
            {
                Console.WriteLine($"Dígito {i}: {frecuenciaDigitos[i]} vez/veces");
            }
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

        static int SumarDigitos(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }

        static int InvertirNumero(int numero)
        {
            int numeroInvertido = 0;
            string numeroInvertidoStr=string.Empty;

            string numeroStr = numero.ToString();
            for (int i = numeroStr.Length - 1; i >= 0; i--)
            {
                char c = Convert.ToChar(numeroStr.Substring(i,1));
                numeroInvertidoStr += c.ToString();
            }
            numeroInvertido =int.Parse(numeroInvertidoStr);
            return numeroInvertido;
        }

        static int[] ContarFrecuenciaDigitos(int numero)
        {
            int[] frecuencia = new int[10];

            while (numero > 0)
            {
                int digito = numero % 10;
                frecuencia[digito]++;
                numero /= 10;
            }

            return frecuencia;
        }
    }
}
