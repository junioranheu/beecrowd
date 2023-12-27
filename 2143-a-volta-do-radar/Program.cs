// https://www.beecrowd.com.br/judge/pt/problems/view/2143
string entrada;

while ((entrada = Console.ReadLine()) != null)
{
    int T = int.Parse(entrada.Trim());

    for (int i = 0; i < T; ++i)
    {
        int N = int.Parse(Console.ReadLine().Trim());

        int pontas = 2 - (N % 2);
        Console.WriteLine(pontas + 2 * (N - pontas));
    }
}