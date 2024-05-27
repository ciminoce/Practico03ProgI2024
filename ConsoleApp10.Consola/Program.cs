namespace ConsoleApp10.Consola
{
    using System;

    class Program
    {
        static void Main()
        {
            const int totalPersonas = 7;
            double sumaAlturas = 0;
            string nombreMasAlto = string.Empty, nombreMasBajo = string.Empty;
            double alturaMasAlta = double.MinValue, alturaMasBaja = double.MaxValue;

            for (int i = 1; i <= totalPersonas; i++)
            {
                string? nombre = PedirString($"Ingrese el nombre de la persona {i}: ");
                double alturaCm = PedirAltura($"Ingrese la altura en centímetros de {nombre}: ");
                double alturaPies = ConvertirAPies(alturaCm);
                Console.WriteLine($"La altura de {nombre} en pies es: {alturaPies:F2}");

                sumaAlturas += alturaCm;

                if (alturaCm > alturaMasAlta)
                {
                    alturaMasAlta = alturaCm;
                    nombreMasAlto = nombre ?? string.Empty;
                }

                if (alturaCm < alturaMasBaja)
                {
                    alturaMasBaja = alturaCm;
                    nombreMasBajo = nombre ?? string.Empty;
                }
            }

            double promedioAltura = sumaAlturas / totalPersonas;

            Console.WriteLine($"\nLa persona más alta es {nombreMasAlto} con una altura de {alturaMasAlta} cm.");
            Console.WriteLine($"La persona más baja es {nombreMasBajo} con una altura de {alturaMasBaja} cm.");
            Console.WriteLine($"El promedio de altura de las personas ingresadas es: {promedioAltura:F2} cm.");
        }

        static string? PedirString(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        static double PedirAltura(string mensaje)
        {
            double altura;
            bool esAlturaValida;

            do
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();
                esAlturaValida = double.TryParse(entrada, out altura) && altura > 0 && altura <= 230;

                if (!esAlturaValida)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese una altura positiva que no exceda los 230 cm.");
                }
            } while (!esAlturaValida);

            return altura;
        }

        static double ConvertirAPies(double alturaCm)
        {
            return alturaCm * 0.0328;
        }
    }
}
