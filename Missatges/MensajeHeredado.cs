using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missatges
{
    public class MensajeHeredado : MissatgeSimple
    {
        /// <summary>
        /// Lo mismo que hace la funcion salutacion pero esta incluye una personalizacion puesta por el usuario.
        /// </summary>
        /// <param name="nombre">Este parametro es customizable por el usuario, cuando el mismo escribe en la caja vacia de propiedad NOMBRE.</param>
        /// <returns>Benvingut NOMBREFULANO.</returns>
        /// <example>
        /// <code>
        /// string mis = "Benvingut " + Leandro + ".";
        /// return mis;
        /// </code>
        /// </example>
        /// <returns>Benvigunt Leandro.</returns>
        public string salutacioAmbNom(string nombre)
        {
            string mis = "Benvingut " + nombre + ".";
            return mis;
        }

        /// <summary>
        /// Este boton te saluda personalmente con el bando que perteneses
        /// </summary>
        /// <param name="nombre">Tu nombre</param>
        /// <param name="bandol">A elegir</param>
        /// <returns>Leandro, benvingut a la First Order</returns>
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
