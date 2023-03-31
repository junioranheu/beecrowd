// https://www.beecrowd.com.br/judge/pt/problems/view/1143
int N = int.Parse(Console.ReadLine());
int pudim = 1;

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"{pudim} {Math.Pow(pudim, 2)} {Math.Pow(pudim, 3)}");

    pudim++;
}