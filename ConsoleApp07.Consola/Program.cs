using ConsoleTables;

namespace ConsoleApp07.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double sumaTemperaturas = 0;
            int temperaturasSuperiores = 0;

            ConsoleTable tabla = new ConsoleTable("Temperatura (°C)", "Fahrenheit (°F)", "Reaumur (°Re)");

            for (int i = 0; i < 10; i++)
            {
                double temperaturaCelsius = Math.Round(rnd.NextDouble() * 30,1); // Genera una temperatura aleatoria entre 0 y 30 grados Celsius
                double temperaturaFahrenheit = CelsiusAFahrenheit(temperaturaCelsius);
                double temperaturaReaumur = CelsiusAReaumur(temperaturaCelsius);

                sumaTemperaturas += temperaturaCelsius;

                if (temperaturaCelsius > 20)
                {
                    temperaturasSuperiores++;
                    tabla.AddRow($"{temperaturaCelsius:N1} *", $"{temperaturaFahrenheit:N2}", $"{temperaturaReaumur:N2}");
                }
                else
                {
                    tabla.AddRow($"{temperaturaCelsius:N1}", $"{temperaturaFahrenheit:N2}", $"{temperaturaReaumur:N2}");
                }
            }
            tabla.Options.EnableCount = false;
            Console.WriteLine(tabla.ToString());

            double mediaTemperaturas = sumaTemperaturas / 10;
            Console.WriteLine($"Media de temperaturas generadas: {mediaTemperaturas:N2} °C");
            Console.WriteLine($"Cantidad de temperaturas superiores a 20°C: {temperaturasSuperiores}");
        }

        static double CelsiusAFahrenheit(double temperaturaCelsius)
        {
            return 1.8*temperaturaCelsius + 32;
        }

        static double CelsiusAReaumur(double temperaturaCelsius)
        {
            return 0.8*temperaturaCelsius ;
        }
    }
}
