using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sobre Fila: A estrutura de fila é do tipo FIFO (First in, First out), ou seja, o primeiro elemento que entra na fila é o primeiro a ser removido; assim, todo primeiro elemento que entra na fila por uma extremidade sairá primeiro pela outra extremidade.

            Queue<int> fila1 = new Queue<int>();
            fila1.Enqueue(1);
            fila1.Enqueue(8);
            fila1.Enqueue(9);
            fila1.Enqueue(-80);

            int x = fila1.ElementAt(0); //na fila permite apenas visualizar o item da posição
            int y = fila1.Dequeue(); //retira o primeiro item da fila

            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(8);
            lista.Add(9);
            lista.Add(-80);

            lista.RemoveAt(0);
        }
    }
}
