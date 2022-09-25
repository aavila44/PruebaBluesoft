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
            int tamaño = listaNumeros.Length;
            int numeroDeMovimientos = 0;
          

            Console.WriteLine($"El arreglo actual es: " + string.Join(", ", listaNumeros));
            try
            {
                Console.Write($"Introduzca el numero de veces que quiere correr el arreglo: ");
                numeroDeMovimientos = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WARNING: Dato invalido, solo se permiten numeros enteros, intetelo de nuevo");
                Environment.Exit(0);
            }
            int movientosEfectivos = numeroDeMovimientos % tamaño;
            if (this.calcularMovimientos(numeroDeMovimientos, tamaño) == false)
            {
                Console.WriteLine($"El arreglo toma su posicion original:" + string.Join(", ", listaNumeros));
                Environment.Exit(0);
            }
            
            Console.Write($"El nuevo arreglo es: ");
            Console.WriteLine(string.Join(", ", arregloFinal(tamaño, movientosEfectivos, listaNumerosAux, listaNumeros)));
        }
        private bool calcularMovimientos(int numeroDeMovimientos, int movientosEfectivos)
        {
            if (numeroDeMovimientos == 0 || movientosEfectivos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int[] arregloFinal(int tamaño, int movientosEfectivos, int[] listaNumerosAux, int[] listaNumeros)
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