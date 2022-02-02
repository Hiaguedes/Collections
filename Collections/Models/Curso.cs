using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Curso
    {
        public int TotalDuracao {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Duracao;
                //}
                //return total;

                // LINQ

                return aulas.Sum(aula => aula.Duracao);
            } 
        }

        // dicionario de alunos

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get { return new ReadOnlyCollection<Aluno>(alunos.ToList<Aluno>()); }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        private string nome;
        private string instrutor;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }


        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        private string LoggerString(IList<Aula> items)
        {
            string result = "";

            foreach (var item in items)
            {
                result += $"{item}, ";
            }

            return result;

        }

        internal void AddAula(Aula aula) 
        { 
            this.aulas.Add(aula);
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno); 
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno); // somente adiciona, nao substitui (estoura erro se tiver um igual), para substituir use this.dicionarioAlunos[numeroMatricula] = aluno
        }

        public Boolean EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatricula(int numeroMatricula)
        {
            //return dicionarioAlunos[numeroMatricula];
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out Aluno aluno);
            return aluno;
        }

        public override string ToString()
        {
            return $"Curso de nome {nome} com instrutor(a) {instrutor} e com cursos {LoggerString(aulas)} e contem uma duracao total de {TotalDuracao} minutos e contem um total de {alunos.Count()} alunos matriculados";
        }

    }
}
