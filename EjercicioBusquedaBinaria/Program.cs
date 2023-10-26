namespace EjercicioBusquedaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] cadenas = { "apple", "banana", "grape", "orange", "pear" };

            // Búsqueda binaria para números enteros
            Console.Write("Ingrese un número para buscar en la lista de enteros: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            int resultadoEnteros = ejercicios.BusquedaBinariaEnteros(numeros, numeroBuscado);
            if (resultadoEnteros != -1)
            {
                Console.WriteLine("El número se encuentra en la posición: " + resultadoEnteros);
            }
            else
            {
                Console.WriteLine("El número no se encuentra en la lista de enteros.");
            }

            // Búsqueda binaria para cadenas
            Console.Write("Ingrese una cadena para buscar en la lista de cadenas: ");
            string cadenaBuscada = Console.ReadLine();
            int resultadoCadenas = ejercicios.BusquedaBinariaCadenas(cadenas, cadenaBuscada);
            if (resultadoCadenas != -1)
            {
                Console.WriteLine("La cadena se encuentra en la posición: " + resultadoCadenas);
            }
            else
            {
                Console.WriteLine("La cadena no se encuentra en la lista de cadenas.");
            }

            // Búsqueda binaria para encontrar el primer número par
            int resultadoNumeroPar = ejercicios.BusquedaBinariaNumeroPar(numeros);
            if (resultadoNumeroPar != -1)
            {
                Console.WriteLine("El primer número par se encuentra en la posición: " + resultadoNumeroPar);
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en la lista de enteros.");
            }

        }
    }
}