using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Aula : IComparable
    {

        public string Cadeira { get; set; }
        public int Duracao { get; set; }

        static int _quantidadeAulas { get; set; } = 0;
        public Aula(string cadeira, int duracao)
        {
            Duracao = duracao;
            Cadeira = cadeira;
            _quantidadeAulas += 1;
        }

        internal static void Logger(List<Aula> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        internal static string LoggerString(List<Aula> items)
        {
            string result = "";

            foreach (var item in items)
            {
                result += $"{item}, ";
            }

            return result;

        }

        internal static int QuantidadeAulasCriadas() { return _quantidadeAulas; }

        public override string ToString()
        {
            return $"Aula com nome de {Cadeira} e Duracao de {Duracao} minutos";
        }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.Cadeira.CompareTo(that.Cadeira);
        }
    }
}
