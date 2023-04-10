// https://www.beecrowd.com.br/judge/pt/problems/view/1158
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] numeros = Console.ReadLine().Split(' ');
    int X = int.Parse(numeros[0]); // Número inicial;
    int Y = int.Parse(numeros[1]); // Qtd ímpares a frente do número inicial;

    if (X % 2 == 0)
    {
        X += 1;
    }

    int total = 0;

    for (int j = 0; j < Y; j++)
    {
        total = total + (X + (2 * j));
    }

    Console.WriteLine(total);
}

// 5 7 9 = 21