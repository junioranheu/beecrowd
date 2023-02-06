// https://www.beecrowd.com.br/judge/pt/problems/view/1042
string[] valores = Console.ReadLine().Split(' ');
int[] valoresOrdenados = new int[valores.Length];

for (int i = 0; i < valores.Length; i++)
{
    int valorLoopAtual = int.Parse(valores[i]);

    for (int j = 0; j < valoresOrdenados.Length; j++)
    {
        if (valorLoopAtual > valoresOrdenados[j])
        {
            EmpurrarLista(valoresOrdenados, j);

            valoresOrdenados[j] = valorLoopAtual;
            break;
        }
    }
}

static void EmpurrarLista(int[] lista, int index)
{
    int[] valoresOrdenadosJar = lista;

    for (int i = index; i < lista.Length; i++)
    {
        if ((i + 1) < lista.Length)
        {
            lista[i + 1] = valoresOrdenadosJar[i];
        }    
    }
}

//Console.WriteLine(valorSort3);
//Console.WriteLine(valorSort2);
//Console.WriteLine(valorSort1);
//Console.WriteLine();

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}

for (int i = 0; i < valoresOrdenados.Length; i++)
{
    Console.WriteLine(valoresOrdenados[i]);
}

Console.ReadKey();