// https://www.beecrowd.com.br/judge/pt/problems/view/1042
string[] lista = Console.ReadLine().Split(' ');
string[] listaOriginal = DeepCopy(lista);
int lenghtMenos2 = lista.Length - 2;

for (int i = 0; i <= lenghtMenos2; i++)
{
    for (int j = 0; j <= lenghtMenos2; j++)
    {
        // Se o valor do loop atual (lista[j]) for maior que o próximo (lista[j + 1])...
        if (int.Parse(lista[j]) > int.Parse(lista[j + 1]))
        {
            string temp = lista[j + 1]; // "Jar" temporária do próximo valor;
            lista[j + 1] = lista[j]; // Salvar o valor atual no lugar do próximo
            lista[j] = temp; // "Empurrar" o valor que foi salvo na temp para o index atual;
        }
    }
}

// Ordem crescente;
for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine();

// Ordem original;
for (int i = 0; i < listaOriginal.Length; i++)
{
    Console.WriteLine(listaOriginal[i]);
}

static string[] DeepCopy(string[] lista)
{
    string[] deepCopy = new string[lista.Length];

    for (int i = 0; i < lista.Length; i++)
    {
        deepCopy[i] = lista[i];
    }

    return deepCopy;
}