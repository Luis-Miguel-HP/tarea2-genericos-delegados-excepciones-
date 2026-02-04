

//interfaz para que el usuario pueda utilizar la aplicacion


using ConsoleApp1.Clases;
using System.Numerics;


int salir = 0;



while (salir != 1)
{
    Console.WriteLine("Bienvenido a la interfaz de usuario, por favor indique el tipo de dato de la lista \n (Int, Double, Float, Decimal,long) ");
    var tipoNumerico = Console.ReadLine()?.ToLower();
    {


        //hacemos un switch para cada caso

        switch (tipoNumerico)
        {
            case "int":
                MiListaNumerica<int> listaInt = new MiListaNumerica<int>();
                Operaciones<int>.Ejecutar(listaInt);
                break;

            case "long":
                MiListaNumerica<long> listaLog = new MiListaNumerica<long>();
                Operaciones<long>.Ejecutar(listaLog);
                break;
            case "float":
                MiListaNumerica<float> listaFloat = new MiListaNumerica<float>();
                Operaciones<float>.Ejecutar(listaFloat);
                break;

            case "decimal":
                MiListaNumerica<decimal> listaDecimal = new MiListaNumerica<decimal>();
                Operaciones<decimal>.Ejecutar(listaDecimal);
                break;
            case "double":
                MiListaNumerica<decimal> listaDouble = new MiListaNumerica<decimal>();
                Operaciones<decimal>.Ejecutar(listaDouble);
                break;

            default:
                Console.WriteLine("Tipo no válido");
                break;


        }
        Console.Clear();
        Console.WriteLine("Quiere realizar otra operacion? S/N");
        var validacion = Console.ReadLine()?.ToLower();


        if (validacion == "s")
        {
            salir = 0;
            Console.Clear();
        }
        else
        {
            salir = 1;
        }

    }
}