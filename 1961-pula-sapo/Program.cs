// https://www.beecrowd.com.br/judge/pt/problems/view/1961
string[] primeiraEntrada = Console.ReadLine().Split(' ');
int P = int.Parse(primeiraEntrada[0]); // Altura do pulo;
int N = int.Parse(primeiraEntrada[1]); // Número de canos;

string[] segundaEntrada = Console.ReadLine().Split(' ');
int ultimo = int.Parse(segundaEntrada[0]);
bool isPerdeu = false;

for (int i = 0; i < N; i++)
{
    int atual = int.Parse(segundaEntrada[i]);

    if ((ultimo - atual) > P || ((ultimo - atual) * -1) > P)
    {
        isPerdeu = true;
    }

    ultimo = atual;
}

Console.WriteLine(isPerdeu ? "GAME OVER" : "YOU WIN");