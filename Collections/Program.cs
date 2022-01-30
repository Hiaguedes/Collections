using Collections.Models;
using Collections.Lista;

string[] aulas = new [] { "teste 1", "teste 2"};

void Logger<T> (T[] items) {
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

int BuscaIndex<T> (T item, T[] items)
{
    return (Array.IndexOf(items, item) != - 1) ? Array.IndexOf(items, item) : throw new ArgumentException("Argumento nao encontrado");
}

void RevertendoArray<T>(T[] items)
{
    Array.Reverse(items);
}

T[] RevertendoArrayCopy<T>(T[] items)
{
    T[] newArray = items.Clone() as T[];

    Array.Reverse(newArray);

    return newArray;
}

Logger<string>(aulas);

Console.WriteLine(BuscaIndex<string>(aulas[0], aulas));

RevertendoArray<string>(aulas);

Logger<string>(aulas);

Console.WriteLine("------------------");

Array.Resize(ref aulas, aulas.Length - 1);
Logger<string>(aulas);

Array.Resize(ref aulas, aulas.Length + 1);
Logger<string>(aulas);
aulas[aulas.Length - 1] = "teste 10";
Logger<string>(aulas);
Console.WriteLine("------------------");
Logger<string>(RevertendoArrayCopy<string>(aulas));
Logger<string>(RevertendoArrayCopy<string>(aulas));

var lista = new Lista();

lista.Logger();
Console.WriteLine(lista.Contador());
lista.Push("Elemento");
lista.Logger();
lista.LoggerList();
Console.WriteLine(lista.FirstOf("dew"));
Console.WriteLine(lista.FirstOf("oioiu"));

Console.WriteLine("------------------");

lista.RemoveIndex(3);
lista.Logger();

Console.WriteLine("------------------");


List<Aula> aulasCriadas = new()
{
    new Aula("Aula de Geometria Aplicada", 130),
    new Aula("Introducao a Computacao", 250),
    new Aula("Estatistica", 121),
};
Console.WriteLine("------------------");
Aula.Logger(aulasCriadas);
Console.WriteLine("------------------");

aulasCriadas.Sort();

Aula.Logger(aulasCriadas);
Console.WriteLine("------------------");

aulasCriadas.Sort((este, outro) => este.Duracao.CompareTo(outro.Duracao));

Aula.Logger(aulasCriadas);

Console.WriteLine("------------------");
Curso cursosCSharp = new("Curso de C#", "Marcelo");
cursosCSharp.AddAula(new Aula("Collections", 123));
cursosCSharp.AddAula(new Aula("Delegate", 250));

Console.WriteLine(cursosCSharp);

Console.WriteLine($"Tempo total de duracao de cursos e de {cursosCSharp.TotalDuracao} minutos");


