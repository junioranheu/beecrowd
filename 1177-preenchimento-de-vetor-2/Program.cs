// https://www.beecrowd.com.br/judge/pt/problems/view/1177
int T = int.Parse(Console.ReadLine());
const int max = 1000;
int n = 0;

for (int i = 0; i < max; i++)
{
    Console.WriteLine($"N[{i}] = {n}");
    n++;

    if (n == T)
    {
        n = 0;
    }
}