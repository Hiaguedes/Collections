using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Lista
{
    internal class Lista
    {
        public Lista()
        {
            Console.WriteLine();
            Console.WriteLine("A partir daqui comeca a classe Lista");
            Console.WriteLine();
        }


        List<string> aulas = new() { "aaaa", "aaaaaaaaa", "dewdededed"};

        internal void Logger()
        {
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

        internal void LoggerList()
        {
            aulas.ForEach(aula => { 
                Console.WriteLine(aula); 
            });
        }

        internal int Contador()
        {
            return aulas.Count;
        }

        internal void Push(string item)
        {
            aulas.Add(item);
        }

        internal string PrimeiroElemento()
        {
            // aulas[0]
            return aulas.First();
        }

        internal string UltimaAula()
        {
            // aulas[aulas.Count -1]
            return aulas.Last();
        }
        

        internal string FirstOf(string item)
        {
            // prcura primeio elemento que contem determinada coisa, pode ser aplicado pro last tbm
            return aulas.FirstOrDefault(aula => aula.Contains(item), "Nao encontrado");
        }

        internal void RemoveIndex(int index)
        {

            // Console.WriteLine(aulas.GetRange(0, aulas.Count() - 1)); copiar uma lista
            if (index < 0 || index > aulas.Count() - 1)
            {
                throw new ArgumentOutOfRangeException("Argumento index maior ou menor que o tamanho atual do array");
            }
            aulas.RemoveAt(index);
        }


    }
}
