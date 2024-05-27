namespace ConsoleApp02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esNumeroValido;

            // Solicitar el número al usuario y validarlo
            do
            {
                Console.Write("Ingrese un número para mostrar su tabla de multiplicar (1 al 12): ");
                string? entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out numero);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            } while (!esNumeroValido);

            // Mostrar la tabla de multiplicar del número ingresado
            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
