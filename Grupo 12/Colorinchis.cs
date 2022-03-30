using System;

namespace Grupo_12
{

    class Colorinchis
    {

        private String[] misColores = {"Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado"};

        public string pillaTremendoColorinchi(int colorinchiID)
        {
            try
            {
            return misColores[colorinchiID];
            }
            catch(OutOfBoundsException e)
            {
                throw new IndexOutOfRangeException("Se fue a tomar viento, hulio.");
            }
        }







    }

}