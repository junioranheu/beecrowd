// https://www.beecrowd.com.br/judge/pt/problems/view/1080
int numeroMaior = 0;
int indexNumeroMaior = 0;

for (int i = 1; i <= 100; i++)
{
    int n = int.Parse(Console.ReadLine());

    if (n > numeroMaior)
    {
        numeroMaior = n;
        indexNumeroMaior = i;
    }
}

Console.WriteLine(numeroMaior);
Console.WriteLine(indexNumeroMaior);