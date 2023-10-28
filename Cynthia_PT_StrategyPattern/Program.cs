using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StrategyPattern
{
    //Se crea la clase donde se insertaran los comportamientos de los objetos para ejecutar//
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los objetos con las estrategias//
            EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerOjitos);
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.InvitarCerveza);
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerCaraDeGalan);
        }
    }
}
