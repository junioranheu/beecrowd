// https://www.beecrowd.com.br/judge/pt/problems/view/1116
int qtdLoop = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdLoop; i++)
{
    string[] numeros = Console.ReadLine().Split(' ');
    int X = int.Parse(numeros[0]);
    int Y = int.Parse(numeros[1]);

    try
    {
        double divisao = (double)X / (double)Y;

        if (double.IsFinite(divisao))
        {
            Console.WriteLine($"{divisao:F1}");
            continue;
        }

        Console.WriteLine("divisao impossivel");
    }
    catch (Exception)
    {
        Console.WriteLine("divisao impossivel");
    }
}