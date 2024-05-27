namespace ConsoleApp13.Consola
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime fechaProximoCumpleaños = DateTime.MaxValue;
            DateTime fechaCumpleañosTardio = DateTime.MinValue;
            string nombreProximoCumpleaños = string.Empty;
            string nombreCumpleañosTardio = string.Empty;
            int totalPersonas = 0;

            while (true)
            {
                string? nombre = PedirString("Ingrese el nombre de la persona (o deje en blanco para finalizar): ");
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    break; // Finalizar ingreso de datos si no se proporciona un nombre
                }

                DateTime fechaNacimiento = PedirFecha("Ingrese la fecha de nacimiento de la persona (MM/DD/YYYY): ");
                TimeSpan diasFaltantes = CalcularDiasFaltantes(DateTime.Today, fechaNacimiento);
                DateTime proximoCumpleaños = ProximoCumpleaños(fechaNacimiento);
                int edad = CalcularEdad(fechaNacimiento);

                Console.WriteLine($"Nombre: {nombre}, Fecha de Nacimiento: {fechaNacimiento.ToString("MM/dd/yyyy")}, " +
                                  $"Edad: {edad}, Días para el próximo cumpleaños: {diasFaltantes.Days}");

                // Actualizar información del cumpleaños más próximo
                if (proximoCumpleaños < fechaProximoCumpleaños)
                {
                    fechaProximoCumpleaños = proximoCumpleaños;
                    nombreProximoCumpleaños = nombre;
                }

                // Actualizar información del cumpleaños más tardío
                if (proximoCumpleaños > fechaCumpleañosTardio)
                {
                    fechaCumpleañosTardio = proximoCumpleaños;
                    nombreCumpleañosTardio = nombre;
                }

                totalPersonas++;
            }

            if (totalPersonas == 0)
            {
                Console.WriteLine("No se ingresaron personas.");
                return;
            }

            Console.WriteLine($"\nEl próximo cumpleaños es de {nombreProximoCumpleaños}.");
            Console.WriteLine($"El cumpleaños más tardío es de {nombreCumpleañosTardio}.");
        }

        static string? PedirString(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha;
            bool esFechaValida;

            do
            {
                Console.Write(mensaje);
                esFechaValida = DateTime.TryParse(Console.ReadLine(), out fecha) 
                    && fecha<=DateTime.Today;

                if (!esFechaValida)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese una fecha válida en el formato MM/DD/YYYY.");
                }
            } while (!esFechaValida);

            return fecha;
        }

        static TimeSpan CalcularDiasFaltantes(DateTime fechaActual,
            DateTime fechaCumpleaños)
        {
            DateTime proximoCumpleaños = ProximoCumpleaños(fechaCumpleaños);
            return proximoCumpleaños - fechaActual;
        }

        static DateTime ProximoCumpleaños(DateTime fechaNacimiento)
        {
            DateTime proximoCumpleaños = new DateTime(DateTime.Today.Year,
                fechaNacimiento.Month, fechaNacimiento.Day);
            if (proximoCumpleaños < DateTime.Today)
            {
                proximoCumpleaños = proximoCumpleaños.AddYears(1);
            }
            return proximoCumpleaños;
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }
    }
}
