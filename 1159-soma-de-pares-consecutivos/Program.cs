// https://www.beecrowd.com.br/judge/pt/problems/view/1159
while (true)
{
    int X = int.Parse(Console.ReadLine());

    if (X == 0)
    {
        break;
    }

    int soma = 0, qtdLoops = 0;
    const int qtdLoopsMaximo = 5;

    while (true)
    {
        if (X % 2 == 0)
        {
            soma += X;
            qtdLoops++;
        }

        if (qtdLoops == qtdLoopsMaximo)
        {
            break;
        }

        X++;
    }

    Console.WriteLine(soma);
}