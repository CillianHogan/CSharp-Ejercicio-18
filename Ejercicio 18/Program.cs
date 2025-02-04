using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, minutos = 0, segundos = 0;

            // Solicitar las horas iniciales al usuario y validar que estén entre 0 y 23
            do
            {
                Console.WriteLine("Ingrese las horas para el temporizador (0-23):");
                horas = int.Parse(Console.ReadLine());

                if (horas < 0 || horas > 23)
                {
                    Console.WriteLine("Error. Las horas deben estar entre 0 y 23.");
                }
            } while (horas < 0 || horas > 23);

            // Solicitar los minutos iniciales al usuario y validar que estén entre 0 y 59
            do
            {
                Console.WriteLine("Ingrese los minutos para el temporizador (0-59)");
                minutos = int.Parse(Console.ReadLine());

                if (minutos < 0 || minutos > 59)
                {
                    Console.WriteLine("Error. Los minutos deben estar entre 0 y 59");
                }
            } while (minutos < 0 || minutos > 59);

            // Solicitar los segundos iniciales al usuario y validar que estén entre 0 y 59
            do
            {
                Console.WriteLine("Ingrese los segundos para el temporizador (0-59)");
                segundos = int.Parse(Console.ReadLine());

                if (segundos < 0 || segundos > 59)
                {
                    Console.WriteLine("Error. Los segundos deben estar entre 0 y 59");
                }
            } while (segundos < 0 || segundos > 59);

            // Verificar que el tiempo total ingresado no sea cero
            if (horas == 0 && minutos == 0 && segundos == 0)
            {
                Console.WriteLine("Error. El temporizador no se puede iniciar a 0");
                return;
            }

            // Iniciar el temporizador con control del menú
            CuentaRegresiva(horas, minutos, segundos);
        }

        static void CuentaRegresiva(int horas, int minutos, int segundos)
        {
            bool enEjecucion = true; // Controla si el temporizador sigue activo
            bool pausado = false; // Controla si el temporizador está pausado

            // Bucle principal del temporizador
            while (enEjecucion)
            {
                if (!pausado)
                {
                    {
                        // Mostrar el tiempo restante en formato HH:MM:SS
                        Console.Clear();
                        Console.WriteLine($"Tiempo restante: {horas:D2}:{minutos:D2}:{segundos:D2}");
                        Thread.Sleep(1000); // Pausa de 1 segundo

                        // Decrementar el tiempo
                        if (segundos > 0)
                        {
                            segundos--;
                        }
                        else if (minutos > 0)
                        {
                            segundos = 59;
                            minutos--;
                        }
                        else if (horas > 0)
                        {
                            segundos = 59;
                            minutos = 59;
                            horas--;
                        }
                        else
                        {
                            // Si el tiempo llega a 0, mostrar mensaje y salir del bucle
                            Console.Clear();
                            Console.WriteLine("¡El tiempo ha terminado!");
                            break;
                        }
                    }
                }

            }


        }
    }
}
