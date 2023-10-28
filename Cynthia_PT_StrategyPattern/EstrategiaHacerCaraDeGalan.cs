using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StrategyPattern
{
    //Se crea la clase y se hace referencia a la interfaz//
    class EstrategiaHacerCaraDeGalan : IBorracho
    {
        public void Conquistar()
        {
            //Se crea la accion que se insertara al referenciar al método//
            Console.WriteLine("Hacer cara de galan");
        }

    }
}
