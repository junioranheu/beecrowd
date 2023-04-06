// https://www.beecrowd.com.br/judge/pt/problems/view/1155
double S = 1;

for (double i = 2; i <= 100; i++)
{
    S += (1 / i);
}

Console.WriteLine($"{S:F2}");