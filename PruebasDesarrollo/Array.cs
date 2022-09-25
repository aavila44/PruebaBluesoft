using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaBluesoft
{
    class Array
    {
        public void rotarElementos()
        {
            int[] listaNumeros = { 75, 82, 11, 56 };
            int[] listaNumerosAux = new int[listaNumeros.Length];
            var tamaño = listaNumeros.Length;
            int m = 0;
            var movientosEfectivos = m % listaNumeros.Length;

            Console.WriteLine($"El arreglo actual es: " + string.Join(", ", listaNumeros));
            try
            {
                Console.Write($"Introduzca el numero de veces que quiere correr el arreglo: ");
                m = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WARNING: Dato invalido, solo se permiten numeros enteros, intetelo de nuevo");
                Environment.Exit(0);
            }

            if (this.movientosEfectivoss(m, tamaño) == true)
            {
                Console.WriteLine($"El arreglo toma su posicion original:" + string.Join(", ", listaNumeros));
                Environment.Exit(0);
            }
            movientosEfectivos = m % tamaño;
            Console.Write($"El nuevo arreglo es: ");
            Console.WriteLine(string.Join(", ", arregloFinal(tamaño, movientosEfectivos, listaNumerosAux, listaNumeros)));
        }
        public bool movientosEfectivoss(int m, int movientosEfectivos)
        {
            if (m == 0 || movientosEfectivos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int[] arregloFinal(int tamaño, int movientosEfectivos, int[] listaNumerosAux, int[] listaNumeros)
        {
            for (int i = 0; i <= tamaño - 1; i++)
            {
                var nuevoIndice = i + movientosEfectivos;
                if (nuevoIndice >= tamaño)
                {
                    nuevoIndice = nuevoIndice - tamaño;
                }
                listaNumerosAux[nuevoIndice] = listaNumeros[i];

                
            }
            return listaNumerosAux;
        }
    }
}
