﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruposAleatoriosLibreria
{

    /// <summary>
    ///  metodo para cambiar el orden en la cadena <br />
    /// </summary>
    public class Randomizer
    {
        public static void Randomize<T>(T[] items)
        {
            Random rand = new Random();
            //desordena el array de forma aleatoria
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }

    public class numeroExcel {

        /// <summary>Metodo que transforma numeros a letras de columnas de excel.</summary>
        /// <param name="columnNumber">Numero que se va transformar.</param>
        /// <returns>
        ///   retorna la letra de la columna del excel. <br />
        /// </returns>
        public string GetExcelColumnName(int columnNumber)
    {
        int dividend = columnNumber;
        string columnName = String.Empty;
        int modulo;

        while (dividend > 0)
        {
            modulo = (dividend - 1) % 26;
            columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
            dividend = (int)((dividend - modulo) / 26);
        }

        return columnName;
    }
}
}
