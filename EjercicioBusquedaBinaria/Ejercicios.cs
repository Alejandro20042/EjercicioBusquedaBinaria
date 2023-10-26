using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace EjercicioBusquedaBinaria
    {
        public class ejercicios { 
        public static int BusquedaBinariaEnteros(int[] numeros, int numeroBuscado)
        {
            int izquierda = 0;
            int derecha = numeros.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (numeros[medio] == numeroBuscado)
                {
                    return medio;
                }

                if (numeros[medio] < numeroBuscado)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1;
        }

        public static int BusquedaBinariaCadenas(string[] cadenas, string cadenaBuscada)
        {
            int izquierda = 0;
            int derecha = cadenas.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                int comparacion = string.Compare(cadenas[medio], cadenaBuscada, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return medio;
                }

                if (comparacion < 0)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1;
        }

        public static int BusquedaBinariaNumeroPar(int[] numeros)
        {
            int izquierda = 0;
            int derecha = numeros.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (numeros[medio] % 2 == 0)
                {
                    return medio;
                }

                if (numeros[medio] < 0)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1;
        }
            }
    }
