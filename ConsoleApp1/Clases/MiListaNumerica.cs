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
        private List<T> Lista;


        public MiListaNumerica() { 
        
            Lista = new List<T>();
        
        }

        public void agregarNumeroLista()
        {

        }
    }


    
  
}
