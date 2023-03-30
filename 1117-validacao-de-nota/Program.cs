// https://www.beecrowd.com.br/judge/pt/problems/view/1117
int contNotasValidas = 0;
double somaNotasValidas = 0;

while (true)
{
    if (contNotasValidas >= 2)
    {
        break;
    }

    double nota = double.Parse(Console.ReadLine());

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("nota invalida");
        continue;
    }

    contNotasValidas++;
    somaNotasValidas += nota;
}

Console.WriteLine($"media = {(somaNotasValidas / contNotasValidas):F2}");