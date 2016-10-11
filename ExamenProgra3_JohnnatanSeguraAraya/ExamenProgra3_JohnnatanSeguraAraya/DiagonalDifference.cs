using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3_JohnnatanSeguraAraya
{
    public class DiagonalDifference
    {
        public int matrix(string cadena)
        {
            int resultado = 0;
            string[] primerSplit = cadena.Split('|');
            string[] segundoSplit;
            int[][] matrizNumeros = new int[0][];
            for (int i = 0; i < primerSplit.Length; i++)
            {
                segundoSplit = primerSplit[i].Split(' ');
                for (int fila = 0; fila < segundoSplit.Length; fila++)
                {
                    for (int columna = 0; columna < segundoSplit.Length; columna++)
                    {
                        matrizNumeros[fila][columna] = int.Parse(segundoSplit[columna]);
                    }
                }               
            }   
                 

            return resultado;
        }

    }
}
