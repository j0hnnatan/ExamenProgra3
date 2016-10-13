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
            string[] primerSplit = cadena.Split('|'); //se realiza el primer split, separando el string por cada '|'
            int[,] matrizNumeros = new int[primerSplit.Length,primerSplit.Length]; //damos longitud a la matriz
            int diagonalUno = 0;
            int diagonalDos = 0;

            for (int fila = 0; fila < primerSplit.Length; fila++) //for que recorre las filas de la matriz
            {
                string[] segundoSplit =  primerSplit[fila].Split(' '); //se realiza el segundo split, separando cada string del primer split por cada espacio vacio

                for (int columna = 0; columna < segundoSplit.Length; columna++) //for que recorre las columnas de la matriz
                {
                    //insertamos los numeros que se encuentran en el segundo split, en las filas d la matriz.
                    //cada vez que se llena una fila, a la variable "segundoSplit" se le agregan los valores de la nueva fila a insertar en la matriz de la variable "primerSplit"
                    matrizNumeros[fila,columna] = int.Parse(segundoSplit[columna]);
                }
           }

            //se tome la longitud de la matriz y se divide por la longotud del primer split 
            //para obtener el numero de vueltas uqe recorre el for
            for (int indice = 0; indice < matrizNumeros.Length / primerSplit.Length; indice++) //for que recorre la primera diagonal
            {
                diagonalUno += matrizNumeros[indice, indice]; //se suma el valor que contiene la matriz en el indice especifico a la variable "diagonalUno".
            }


            //se tome la longitud de la matriz y se divide por la longotud del primer split, luego se resta uno(esto para que no este en un indice de la matriz fuera de rango)
            //para obtener el numero de vueltas uqe recorre el for 
            for (int fila = 0, columna = (matrizNumeros.Length / primerSplit.Length) - 1; columna >= 0; columna--,fila++)
            {
                diagonalDos += matrizNumeros[fila, columna]; //se suma el valor que contiene la matriz en el indice especifico a la variable "diagonalDos".
            }

            resultado = diagonalUno - diagonalDos; //se realiza la resta respectiva para obtener el valor deseado
            return resultado;
        }

    }
}
