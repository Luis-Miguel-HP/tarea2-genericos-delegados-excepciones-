using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class MiListaNumerica<T> where T : INumber<T>

    {

        public delegate T OperacionMatematica(T a, T b);


        private List<T> Lista;


        public MiListaNumerica()
        {

            Lista = new List<T>();

        }

        public void agregarNumeroLista(T numero)
        {
            Lista.Add(numero);
        }


        //delegados segun cada operacion

        public static T Sumar(T a, T b) => a + b;
        public static T Restar(T a, T b) => a - b;
        public static T Multiplicar(T a, T b) => a * b;


        public static T Dividir(T a, T b)
        {
            if(b == T.Zero )
            {
                throw new DivideByZeroException("El divisor no puede ser igual a cero para realziar la operacion");
            }
            return a / b;

        }


        public T AplicarOperacion(OperacionMatematica matematica)
        {


            if (Lista.Count < 2)
            {
                Console.WriteLine("No se puede realizar operaciones si la lista está vacía o tiene menos de 2 elementos.");
                throw new InvalidOperationException("Operación inválida: lista insuficiente.");
            }
            return matematica(Lista[0], Lista[1]);

        }

    }
}
