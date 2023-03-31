// https://www.beecrowd.com.br/judge/pt/problems/view/1133
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

if (X > Y)
{
    int jar = Y;
    Y = X;
    X = jar;
}

for (int i = X; i < Y; i++)
{
    if ((i % 5 == 2 || i % 5 == 3) && (i != X))
    {
        Console.WriteLine(i);
    }
}