// https://www.beecrowd.com.br/judge/pt/problems/view/1837
string[] valores = Console.ReadLine().Split(' ');
int a = int.Parse(valores[0]);
int b = int.Parse(valores[1]);

int q = 0, r = 0;

if (a >= 0)
{
    q = a / b; // Quociente = resultado da divisão;
    r = a % b; // Resto da divisão;
}
else
{
    int x = 0, y = 0;

    if (b < 0)
    {
        x = b * -1;
    }
    else
    {
        x = b;
    }

    for (r = 0; r < x; r++)
    {
        y = a - r;

        if (y % b == 0)
        {
            break;
        }
    }

    q = y / b;
}

Console.WriteLine($"{q} {r}");