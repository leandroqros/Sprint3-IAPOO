namespace Missatges
{
    public class MissatgeSimple
    {
        /// <summary>
        /// Funcion saudacion. Esta funcion te dá las bienvenidas al programa.
        /// </summary>
        /// <returns>String que continene "Benvingut"</returns>
        public string salutacio()
        {
            string mis = "Benvingut";
            return mis;
        }
        /// <summary>
        /// Funcion de Adios. Esta funcion se despide de ti cuando le presionas el boton.
        /// </summary>
        /// <returns>String que contiene "Adeu, fins aviat"</returns>
        /// <remarks>Añadida una variable STRING con nombre mis, le damos un valor entre "".</remarks>
        public virtual string comiat()
        {
            string mis = "Adeu, fins aviat";
            return mis;
        }
    }
}
