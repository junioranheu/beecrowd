// https://www.beecrowd.com.br/judge/pt/problems/view/1179
// using System.Collections.Generic;

const int loops = 15;
const int maxVetor = 5;

List<int> listaPar = new List<int>();
List<int> listaImpar = new List<int>();

for (int i = 0; i < loops; i++)
{
    int X = int.Parse(Console.ReadLine());

    if (X % 2 == 0)
    {
        listaPar.Add(X);
    }
    else
    {
        listaImpar.Add(X);
    }

    if (listaPar.Count == maxVetor)
    {
        ExibirLista(listaPar, "par", maxVetor);
        listaPar.Clear();
    }

    if (listaImpar.Count == maxVetor)
    {
        ExibirLista(listaImpar, "impar", maxVetor);
        listaImpar.Clear();
    }
}

ExibirLista(listaImpar, "impar", maxVetor);
ExibirLista(listaPar, "par", maxVetor);

static void ExibirLista(List<int> lista, string texto, int maxVetor)
{
    try
    {
        for (int i = 0; i < maxVetor; i++)
        {
            Console.WriteLine($"{texto}[{i}] = {lista[i]}");
        }
    }
    catch (Exception)
    {

    }
}