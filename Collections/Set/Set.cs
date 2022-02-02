using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// o set nao adiciona elemento duplicado e nao coloca todos os elementos na ultima posicao (se um elemento foi retirado e outro foi adicionado, esse novo adicionado sera colocado
// no local do que foi retirado

// e mais rapido para colocar e buscar elementos

namespace Collections.Set
{
    internal class Set
    {
        private ISet<string> alunos = new HashSet<string>();
        

        public void AddMany(string[] items)
        {
            foreach(var aluno in items)
            {
                alunos.Add(aluno);
            }
        }

        public void Add(string aluno)
        {
            alunos.Add(aluno);
        }

        public override string ToString()
        {
            return $"Os alunos cadastrados sao {string.Join(", ", alunos)}";
        }

        public string Ordena() 
        {
            List<string> list = new(alunos);

            list.Sort();

            return string.Join(", ", list);
        }
    }
}
