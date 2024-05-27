using System.Text.RegularExpressions;

namespace ConsoleApp04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cadena de texto: ");
            string? texto = Console.ReadLine();

            texto = EliminarEspaciosExtras(texto);

            int cantidadPalabras = ContarPalabras(texto);

            Console.WriteLine($"La cadena de texto tiene {cantidadPalabras} palabras.");
        }

        static int ContarPalabras(string texto)
        {
            int conteoPalabras = 0;
            bool esPalabra = false;

            foreach (char caracter in texto)
            {
                if (char.IsWhiteSpace(caracter))
                {
                    if (esPalabra)
                    {
                        conteoPalabras++;
                        esPalabra = false;
                    }
                }
                else
                {
                    esPalabra = true;
                }
            }

            if (esPalabra)
            {
                conteoPalabras++;
            }

            return conteoPalabras;
        }

        static string EliminarEspaciosExtras(string? texto)
        {
            // Utilizamos una expresión regular para reemplazar múltiples espacios consecutivos por un solo espacio
            return texto!=null? Regex.Replace(texto, @"\s+", " "):string.Empty;
        }
    }
}
