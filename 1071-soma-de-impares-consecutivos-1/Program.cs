// https://www.beecrowd.com.br/judge/pt/problems/view/1071
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

int maior = X > Y ? X : Y;
int menor = X < Y ? X : Y;

int somaImpares = 0;

for (int i = menor; i < maior; i++)
{
    if (IsImpar(i) && (i != menor) && (i != maior))
    {
        somaImpares += i;
    }
}

Console.WriteLine(somaImpares);

static bool IsImpar(int i)
{
    return i % 2 != 0;
}