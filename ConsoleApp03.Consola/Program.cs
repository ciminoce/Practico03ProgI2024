namespace ConsoleApp03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string? palabra = Console.ReadLine();

            int cantidadVocales = ContarVocales(palabra);

            Console.WriteLine($"La palabra '{palabra}' tiene {cantidadVocales} vocales.");
        }

        static int ContarVocales(string? palabra)
        {
            int conteo = 0;
            palabra = palabra?.ToLower(); // Convertir la palabra a minúsculas para comparar con las vocales

            if (palabra is not null)
            {
                foreach (char letra in palabra)
                {
                    if (EsVocal(letra))
                    {
                        conteo++;
                    }
                }

            }
            return conteo;
        }

        static bool EsVocal(char letra)
        {
            return "aeiou".Contains(letra);
        }
    }
}
