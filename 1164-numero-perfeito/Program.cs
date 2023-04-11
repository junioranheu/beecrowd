// https://www.beecrowd.com.br/judge/pt/problems/view/1164
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());

    int totalDivisoresX = 0;

    for (int j = 1; j < X; j++)
    {
        if (X % j == 0)
        {
            totalDivisoresX += j;
        }
    }

    bool is_X_Perfeito = X == totalDivisoresX;

    Console.WriteLine($"{X}{(!is_X_Perfeito ? " nao " : " ")}eh perfeito");
}