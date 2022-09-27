using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missatges
{
    public class MensajeHeredado : MissatgeSimple
    {
        public string salutacioAmbNom(string nombre)
        {
            string mis = "Benvingut " + nombre + ".";
            return mis;
        }

        public string salutacioAmbNomiBandol(string nombre, string bandol)
        {
            string mis = nombre + ", benvingut a la " + bandol;
            return mis;
        }
        public override string comiat()
        {
            string mis = "Bye, don't back here.";
            return mis;
        }

        public string comiatCatala()
        {
            string msg = base.comiat();
            return msg;
        }
    }
}
