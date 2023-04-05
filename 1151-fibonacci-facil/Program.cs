// https://www.beecrowd.com.br/judge/pt/problems/view/1151
int N = int.Parse(Console.ReadLine());

int anterior = 0, atual = 1;
string msg = "0 ";

for (int i = 0; i < N - 1; i++)
{
    msg += $"{atual} ";
    atual = atual + anterior;
    anterior = atual - anterior;
}

Console.WriteLine(msg.TrimEnd(' '));