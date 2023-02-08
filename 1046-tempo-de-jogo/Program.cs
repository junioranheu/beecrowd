// https://www.beecrowd.com.br/judge/pt/problems/view/1046
string[] horas = Console.ReadLine().Split(' ');

int inicio = int.Parse(horas[0]);
int fim = int.Parse(horas[1]);
int diferenca = 0;

if (inicio == 0 && fim == 0)
{
    diferenca = 24;
}
else if (inicio < fim)
{
    diferenca = inicio - fim;
    diferenca = diferenca - (diferenca * 2);
}
else
{
    int ateMeiaNoite = 24 - inicio;
    diferenca = ateMeiaNoite + fim;
}

Console.WriteLine($"O JOGO DUROU {diferenca} HORA(S)");