// https://www.beecrowd.com.br/judge/pt/problems/view/1048
double salario = double.Parse(Console.ReadLine());

double percentualReajuste = VerificarPercentualReajuste(salario);

Console.WriteLine($"Novo salario: {(salario + (salario * (percentualReajuste / 100))):F2}");
Console.WriteLine($"Reajuste ganho: {(salario * (percentualReajuste / 100)):F2}");
Console.WriteLine($"Em percentual: {percentualReajuste} %");

static double VerificarPercentualReajuste(double salario)
{
    if (salario >= 0 && salario <= 400)
    {
        return 15;
    }
    else if (salario >= 400.01 && salario <= 800)
    {
        return 12;
    }
    else if (salario >= 800.01 && salario <= 1200)
    {
        return 10;
    }
    else if (salario >= 1200.01 && salario <= 2000)
    {
        return 7;
    }
    else
    {
        return 4;
    }
}