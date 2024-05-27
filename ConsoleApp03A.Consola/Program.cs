
namespace ConsoleApp03A.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palabra = null;
            do
            {
                Console.Write("Ingrese una palabra:");
                palabra = Console.ReadLine();
                if (!ValidarPalabra(palabra))
                {
                    Console.WriteLine("Palabra no válida... Favor de reintentar");
                }
                else
                {
                    break;
                }

            } while (true);

            int cantidadVocales = ContarVocales(palabra);
            int cantidadConsonantes = ContarConsonantes(palabra);
            Console.WriteLine($"{palabra} tiene {cantidadVocales} vocales");
            Console.WriteLine($"y {cantidadConsonantes} consonantes");
        }

        private static int ContarConsonantes(string? palabra)
        {
            if (palabra == null) return 0;
            return palabra.Length - ContarVocales(palabra);
        }

        private static int ContarVocales(string? palabra)
        {
            var cantidad = 0;
            if (palabra != null)
            {
                foreach (char c in palabra)
                {
                    if (EsVocal(c))
                    {
                        cantidad++;
                    }
                }

            }
            return cantidad;
        }

        private static bool EsVocal(char c)
        {
            return "aeiou".Contains(c);
        }

        private static bool ValidarPalabra(string? palabra)
        {
            if (string.IsNullOrEmpty(palabra)) return false;
            if (palabra.Length < 3) return false;
            foreach (char c in palabra)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
