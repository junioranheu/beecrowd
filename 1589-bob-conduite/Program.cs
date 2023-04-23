// https://www.beecrowd.com.br/judge/pt/problems/view/1589
int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int R1 = int.Parse(valores[0]);
    int R2 = int.Parse(valores[1]);

    Console.WriteLine(R1 + R2);
}