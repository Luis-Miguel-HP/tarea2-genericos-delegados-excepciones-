using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Operaciones<T> where T : INumber<T>
    {

        public static void Ejecutar(MiListaNumerica<T> lista)
        {
            int salir = 0;
            while(salir != 6)
            {
            //Console.Clear()
            Console.WriteLine("Que accione le gustaria realizar: \n Agregar numero: 1  Sumar:2  Restar:3  Multiplicar:4  Dividir:5  Salir:6");
                var op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Escriba el número:");
                        string input = Console.ReadLine();

                        if (T.TryParse(input, null, out T num))
                        {
                            lista.agregarNumeroLista(num);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"El resultado de la suma es:{lista.AplicarOperacion(MiListaNumerica<T>.Sumar)}");
                    
                        break;
                    case 3:
                        Console.WriteLine($"El resultado de la suma es:{lista.AplicarOperacion(MiListaNumerica<T>.Restar)}");
                     
                        break;
                    case 4:
                        Console.WriteLine($"El resultado de la suma es:{lista.AplicarOperacion(MiListaNumerica<T>.Multiplicar)}");

                        break;
                    case 5:
                        Console.WriteLine($"El resultado de la suma es:{lista.AplicarOperacion(MiListaNumerica<T>.Dividir)}");
                      
                        break;

                    case 6:
                        Console.Clear();
                        salir = 6;
                        break;




                }

            }
        }

        internal void Ejecutar(MiListaNumerica<int> listaInt)
        {
            throw new NotImplementedException();
        }
    }
}
