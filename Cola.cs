using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class Cola : IColleccion
    {
        private List<object> lista;

        public Cola()
        {
            lista = new List<object>();
        }

        public bool EstaVacia()
        {
            return lista.Count == 0;
        }

        public object Extraer()
        {
            
            object elemento = lista[0];
            lista.RemoveAt(0); // Elimina el primer elemento (FIFO)
            return elemento;
        }

        public object Primero()
        {
            
            return lista[0];
        }

        public bool Anadir(object objeto)
        {
            lista.Add(objeto); // Añade el elemento al final de la lista (FIFO)
            return true;
        }
    }
}
