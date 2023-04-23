// https://www.beecrowd.com.br/judge/pt/problems/view/1564
while (true)
{
    string Nstr = Console.ReadLine();

    if (Nstr == null)
    {
        break;
    }

    int N = int.Parse(Nstr);

    if (N == 0)
    {
        Console.WriteLine("vai ter copa!");
    } else
    {
        Console.WriteLine("vai ter duas!");
    }
}