// https://www.beecrowd.com.br/judge/pt/problems/view/1153
int N = int.Parse(Console.ReadLine());

int total = N;

for (int i = 1; i < N; i++)
{
    total *= i;
}

Console.WriteLine(total);