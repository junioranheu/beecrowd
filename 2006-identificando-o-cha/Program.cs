// https://www.beecrowd.com.br/judge/pt/problems/view/2006
int T = int.Parse(Console.ReadLine());
string[] entrada = Console.ReadLine().Split(' ');
int qtdOk = 0;

for (int i = 0; i < entrada.Length; i++)
{
    if (int.Parse(entrada[i]) == T)
    {
        qtdOk++;
    }
}

Console.WriteLine(qtdOk);