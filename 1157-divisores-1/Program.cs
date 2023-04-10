// https://www.beecrowd.com.br/judge/pt/problems/view/1157
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (N % i == 0)
    {
        Console.WriteLine(i);
    }
}