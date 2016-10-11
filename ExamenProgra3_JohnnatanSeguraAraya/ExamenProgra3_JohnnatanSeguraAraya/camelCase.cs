using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3_JohnnatanSeguraAraya
{
    public class camelCase
    {
        public int calculate(string camelCaseWord)
        {
            int resultado = 0;

            //evalua si el string que viene por parametro esta vacio o es nulo, esto para seguir con el resto del codigo o retornar cero
            if (!string.IsNullOrWhiteSpace(camelCaseWord))
            {
                //si el string contiene almenos una palabra, 
                //cambia la variable "resultado" a 1 porque se toma en cuanta que la primera palabra todas sus letras estan en minuscula
                resultado = 1;

                //luego un for que recorre todas las letras del string que viene por parametro
                for (int posicion = 0; posicion < camelCaseWord.Length; posicion++)
                {
                    //se evalua cada letra del string, utilizando la clase 'char',
                    //donde nos indica si la letra del string en una posicion  especifica es mayuscula o nimuscula
                    if (char.IsUpper(camelCaseWord[posicion]))
                    {
                        //si la letra del string en la posicion que se evaluo es mayuscula, se incrementa la variable "resultado en uno"
                        resultado++;
                    }
                }
            }
            return resultado;
        }
    }
}
