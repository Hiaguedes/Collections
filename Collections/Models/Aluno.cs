using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"Aluno de nome {nome} e Matricula {numeroMatricula}";
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Aluno;
            if (other == null) {
                return false;
             }
            return other.numeroMatricula == this.numeroMatricula;
        }

        public override int GetHashCode()
        {
            return this.numeroMatricula.GetHashCode();
        }

    }
}

/*
 É preciso implementar (sobreescrever) o método Equals() da classe object na classe Aula para retornar True se os títulos das duas instâncias da classe Aula forem iguais, e implementar também o método GetHashCode() para retornar o mesmo código de dispersão caso os títulos forem iguais.


Muito bem! O método Equals define se dois objetos são iguais, porém ele também depende da implementação correta do método GetHashCode(), que deverá retornar o mesmo número de dispersão para objetos considerados iguais. 
 */


