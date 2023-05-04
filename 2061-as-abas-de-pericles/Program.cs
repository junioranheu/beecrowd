// https://www.beecrowd.com.br/judge/pt/problems/view/2061
string[] entradas = Console.ReadLine().Split(' ');
int N = int.Parse(entradas[0]); // Número inicial de abas;
int M = int.Parse(entradas[1]); // Número de ações;

for (int i = 0; i < M; i++)
{
    string acao = Console.ReadLine();

    if (acao == "fechou")
    {
        N += -1 + 2;
    }
    else if (acao == "clicou")
    {
        N -= 1;
    }
}

Console.WriteLine(N);