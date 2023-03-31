// https://www.beecrowd.com.br/judge/pt/problems/view/1144
int N = int.Parse(Console.ReadLine());
int aea = 1;

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"{aea} {Math.Pow(aea, 2)} {Math.Pow(aea, 3)}");
    Console.WriteLine($"{aea} {Math.Pow(aea, 2) + 1} {Math.Pow(aea, 3) + 1}");

    aea++;
}