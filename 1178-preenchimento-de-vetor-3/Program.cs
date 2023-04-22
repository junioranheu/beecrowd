// https://www.beecrowd.com.br/judge/pt/problems/view/1178
//decimal X = decimal.Parse(Console.ReadLine());
//const int max = 100;

//for (int i = 0; i < max; i++)
//{
//    if (i == 0)
//    {
//        Console.WriteLine($"N[{i}] = {X}");
//        continue;
//    }

//    X = decimal.Round(X / 2, 10, MidpointRounding.ToEven);
//    Console.WriteLine($"N[{i}] = {X/2:F4}");
//}

decimal x = decimal.Parse(Console.ReadLine());
decimal y = 0;
decimal[] vet = new decimal[100];

vet[0] = x;

Console.WriteLine("N[0] = " + vet[0].ToString("F4"));
y = x / 2;

for (int i = 1; i < 100; i++)
{
    vet[i] = y;
    y = y / 2;
}

for (int i = 1; i < 100; i++)
{
    Console.WriteLine($"N[{i}] = {decimal.Round(vet[i], 4, MidpointRounding.ToEven)}");
}