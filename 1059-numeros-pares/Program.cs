// https://www.beecrowd.com.br/judge/pt/problems/view/1059
for(int i = 1; i <= 100; i++)
{
    if (IsPar(i))
    {
        Console.WriteLine(i);
    } 
}

static bool IsPar(int i )
{
    return i % 2 == 0;
}