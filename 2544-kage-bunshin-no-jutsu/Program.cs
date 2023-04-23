// https://www.beecrowd.com.br/judge/pt/problems/view/2544
// using static System.Math;

while (true)
{
    string Nstr = Console.ReadLine();

    if (Nstr == null)
    {
        break;
    }

    int N = int.Parse(Nstr);

    if (N == 1 || N == 0)
    {
        Console.WriteLine(0);
        continue;
    }

    Console.WriteLine(Math.Log(N, 2));
}