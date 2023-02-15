// https://www.beecrowd.com.br/judge/pt/problems/view/1073
int N = int.Parse(Console.ReadLine());

for (int i = 0; i <= N; i++)
{
    if ((i % 2 == 0) && (i > 0))
    {
        Console.WriteLine($"{i}^{2} = {Math.Pow(i, 2)}");
    }
}