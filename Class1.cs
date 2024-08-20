using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class Pila : IColleccion
    {
        private const int CAPACIDAD_INICIAL = 10;
        private object[] elementos;
        private int contador;

        public Pila()
        {
            elementos = new object[CAPACIDAD_INICIAL];
            contador = 0;
        }

        public bool EstaVacia()
        {
            return contador == 0;
        }

        public object Extraer()
        {
            
            object elemento = elementos[contador - 1];
            elementos[contador - 1] = null; 
            contador--;
            return elemento;
        }

        public object Primero()
        {
            
            return elementos[contador - 1];
        }

        public bool Anadir(object objeto)
        {
            
            elementos[contador] = objeto;
            contador++;
            return true;
        }

        
    }
}
