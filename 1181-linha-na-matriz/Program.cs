// https://www.beecrowd.com.br/judge/pt/problems/view/1181
int L = int.Parse(Console.ReadLine()); // Linha;
string T = Console.ReadLine(); // Operação;
const int qtdColunas = 12;
double[,] M = new double[qtdColunas, qtdColunas]; // Matriz;

// Obs: é necessário passar por todas linhas e colunas;
for (int i = 0; i < qtdColunas; i++)
{
    for (int j = 0; j < qtdColunas; j++)
    {
        M[i, j] = double.Parse(Console.ReadLine());
    }
}

double resultado = 0;

for (int i = 0; i < M.GetLength(0); i++)
{
    resultado += M[L, i];
}

if (T == "S")
{
    Console.WriteLine($"{resultado:F1}");
}
else if (T == "M")
{
    Console.WriteLine($"{(resultado / M.GetLength(0)):F1}");
}