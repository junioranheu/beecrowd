// https://www.beecrowd.com.br/judge/pt/problems/view/1065
const int qtdLoops = 5;
int numerosPares = 0;

for (int i = 0; i < qtdLoops; i++)
{
    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        numerosPares += 1;
    }
}

Console.WriteLine($"{numerosPares} valores pares");