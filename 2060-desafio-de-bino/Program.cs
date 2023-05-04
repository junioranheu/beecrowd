// https://www.beecrowd.com.br/judge/pt/problems/view/2060
int N = int.Parse(Console.ReadLine());
string[] entradas = Console.ReadLine().Split(' ');
int multiplos2 = 0, multiplos3 = 0, multiplos4 = 0, multiplos5 = 0;

for (int i = 0; i < N; i++)
{
    int num = int.Parse(entradas[i]);

    if (num % 2 == 0)
    {
        multiplos2++;
    }

    if (num % 3 == 0)
    {
        multiplos3++;
    }

    if (num % 4 == 0)
    {
        multiplos4++;
    }

    if (num % 5 == 0)
    {
        multiplos5++;
    }
}

Console.WriteLine($"{multiplos2} Multiplo(s) de 2");
Console.WriteLine($"{multiplos3} Multiplo(s) de 3");
Console.WriteLine($"{multiplos4} Multiplo(s) de 4");
Console.WriteLine($"{multiplos5} Multiplo(s) de 5");