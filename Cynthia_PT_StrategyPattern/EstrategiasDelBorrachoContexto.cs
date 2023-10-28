using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_StrategyPattern
{
    //Se crea una clase con el contexto//
    class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;

        //Se referencian las estrategias que se insertaran al ejecutar el código//
        public enum Comportamiento
        {
            HacerOjitos, InvitarCerveza, HacerCaraDeGalan
        }

        public EstrategiasDelBorrachoContexto()
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        

        /*
        public void EstablecerConquistaOjitos()
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistaInvitarCerveza()
        {
            this.oBorracho = new EstrategiaInvitarCerveza();
        }*/
        
        //Se inserta la siguiente función para insertar las diferentes opciones dependiendo de cada método//
        public void Conquistar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case Comportamiento.HacerOjitos:
                     {
                        this.oBorracho = new EstrategiaOjitos();
                     }break;
                case Comportamiento.InvitarCerveza:
                    {
                        this.oBorracho = new EstrategiaInvitarCerveza();
                    }break;
                case Comportamiento.HacerCaraDeGalan:
                    {
                        this.oBorracho = new EstrategiaHacerCaraDeGalan();
                    }
                    break;
            }
            this.oBorracho.Conquistar();
        }





    }
}
