// https://www.beecrowd.com.br/judge/pt/problems/view/1866
int C = int.Parse(Console.ReadLine());

for (int i = 0; i < C; i++)
{
    int N = int.Parse(Console.ReadLine());

    int qtdSoma = N % 2 == 0 ? (N / 2) : ((N / 2) + 1);
    int qtdSubtracao = (N / 2);

    int S = qtdSoma - qtdSubtracao;

    Console.WriteLine(S);
}