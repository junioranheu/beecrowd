// https://www.beecrowd.com.br/judge/pt/problems/view/2059
// using System;
// using System.Collections.Generic;
// using System.Linq;

List<int> entrada = Console.ReadLine().Trim().Split(' ').Select((x) => int.Parse(x)).ToList();

if (entrada[3] == 1)
{
    if (entrada[4] == 1)
    {
        Console.WriteLine("Jogador 2 ganha!");
    }
    else
    {
        Console.WriteLine("Jogador 1 ganha!");
    }
}
else
{
    if (entrada[4] == 1)
    {
        Console.WriteLine("Jogador 1 ganha!");
    }
    else
    {
        Console.WriteLine($"Jogador {((entrada[1] + entrada[2]) % 2 == (1 - entrada[0]) ? 1 : 2)} ganha!");
    }
}