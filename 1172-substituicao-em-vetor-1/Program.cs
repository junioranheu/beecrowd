// https://www.beecrowd.com.br/judge/pt/problems/view/1172
int[] X = new int[10];

for (int i = 0; i < X.Length; i++)
{
    X[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < X.Length; i++)
{
    if (X[i] < 1)
    {
        X[i] = 1;
    }
}

for (int i = 0; i < X.Length; i++)
{
    Console.WriteLine($"X[{i}] = {X[i]}");
}