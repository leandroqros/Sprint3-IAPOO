﻿namespace Missatges
{
    public class MissatgeSimple
    {
        public string salutacio()
        {
            string mis = "Benvingut";
            return mis;
        }
        public string salutacio(string nombre)
        {
            string mis = "Benvingut " + nombre + ".";
            return mis;
        }

        public virtual string comiat()
        {
            string mis = "Adeu, fins aviat";
            return mis;
        }
    }
}