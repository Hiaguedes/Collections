using Collections.Models;
using Collections.Lista;
using Collections.Set;


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


Console.WriteLine("------------------");


var set = new Set();

set.AddMany(new [] { "Luffy", "Nami", "Zoro", "Usopp" });
set.Add("Luffy");


Console.WriteLine(set);

Console.WriteLine(set.Ordena());

List<Aluno> alunos = new ()
{
    new Aluno("Luffy", 12143),
    new Aluno("Nami", 15487),
    new Aluno("Zoro", 7845),
    new Aluno("Usopp", 32687),
};

cursosCSharp.Matricula(alunos.First());
Console.WriteLine(cursosCSharp);

Console.WriteLine("Aluno Luffy esta matriculado? " + cursosCSharp.EstaMatriculado(alunos.Find(aluno => aluno.Nome == "Luffy")));

Console.WriteLine(new Aluno("Luffy", 12143).Equals(alunos.Find(aluno => aluno.Nome == "Luffy")));

Console.WriteLine(cursosCSharp.BuscaMatricula(12143));
Console.WriteLine(cursosCSharp.BuscaMatricula(121413));

Console.WriteLine("Lista Ligada");
Console.WriteLine();

// Isso mesmo! Cada elemento de um LinkedList é um nó, ou seja, um objeto LinkedListNode, que mantém duas referências, apontando para o nó anterior e outra apontando para o próximo nó,
// e essa lista pode ser navegada pela ordem definida pela associação entre esses nós.

LinkedList<string> list = new LinkedList<string>();

var node = list.AddFirst("1");
list.AddBefore(node, "2");
list.AddAfter(node.Previous, "10");

var nodeRef = list.Find("10");

Console.WriteLine(nodeRef.ValueRef);

Console.WriteLine(string.Join(", ", list));
Console.WriteLine(node.Value);

var stack = new Stack<string>();

stack.Push("10");
stack.Push("20");
stack.Push("3");
stack.Pop();

Console.WriteLine(String.Join(", ", stack));
Console.WriteLine(stack.Peek());

var fila = new Queue<string>();

fila.Enqueue("111");
fila.Enqueue("222");  
fila.Enqueue("333");
fila.Dequeue();

Console.WriteLine(string.Join(", ", fila));
