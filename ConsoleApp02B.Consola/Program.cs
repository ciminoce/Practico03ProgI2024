using System.Text;

namespace ConsoleApp02B.Consola
{
    internal class Program
    {
        static void Main()
        {
            int numero = LeerNumero("Ingrese un número para mostrar su tabla de multiplicar: ");
            int inicio = LeerNumero("Ingrese el número de inicio de la tabla de multiplicar: ");
            int fin = LeerNumero("Ingrese el número final de la tabla de multiplicar: ");

            string tablaMultiplicar = GenerarTablaDeMultiplicar(numero, inicio, fin);
            Console.WriteLine(tablaMultiplicar);
        }

        static int LeerNumero(string mensaje)
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

        static string GenerarTablaDeMultiplicar(int numero, int inicio, int fin)
        {
            StringBuilder tabla = new StringBuilder();

            tabla.AppendLine($"Tabla de multiplicar del {numero} desde {inicio} hasta {fin}:");

            for (int i = inicio; i <= fin; i++)
            {
                int resultado = numero * i;
                tabla.AppendLine($"{numero} x {i} = {resultado}");
            }

            return tabla.ToString();
        }
    }
}
