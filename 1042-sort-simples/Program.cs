// https://www.beecrowd.com.br/judge/pt/problems/view/1042
string[] lista = Console.ReadLine().Split(' ');
string[] listaOriginal = DeepCopy(lista);

for (int i = 0; i <= lista.Length - 2; i++)
{
    for (int j = 0; j <= lista.Length - 2; j++)
    {
        if (int.Parse(lista[j]) > int.Parse(lista[j + 1]))
        {
            int temp = int.Parse(lista[j + 1]);
            lista[j + 1] = lista[j];
            lista[j] = temp.ToString();
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