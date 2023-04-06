// https://www.beecrowd.com.br/judge/pt/problems/view/1154
double total = 0.0;
int qtdLoop = 0;

while (true)
{
    int idade = int.Parse(Console.ReadLine());

    if (idade < 0)
    {
        break;
    }

    total += idade;
    qtdLoop++;
}

Console.WriteLine($"{(total / qtdLoop):F2}");