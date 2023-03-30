// https://www.beecrowd.com.br/judge/pt/problems/view/1115
while (true)
{
    string[] quadrantes = Console.ReadLine().Split(' ');
    int? X = int.Parse(quadrantes[0]);
    int? Y = int.Parse(quadrantes[1]);

    if (X == null || X == 0 || Y == null || Y == 0)
    {
        break;
    }

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("quarto");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("segundo");
    }
}