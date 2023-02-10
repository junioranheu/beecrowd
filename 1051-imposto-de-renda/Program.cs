// https://www.beecrowd.com.br/judge/pt/problems/view/1051
double salario = double.Parse(Console.ReadLine());

if (salario <= 2000)
{
    Console.WriteLine("Isento");
}
else
{
    Console.WriteLine($"R$ {ChecarImpostoDeRenda(salario):F2}");
}

static double ChecarImpostoDeRenda(double salario)
{
    double impostoTotal = 0;

    if (salario >= 2000.01)
    {
        double maximo = salario < 3000 ? salario : 3000;
        double imposto = ((maximo - 2000) * (8.0 / 100.0));
        impostoTotal += imposto;
    }

    if (salario >= 3000.01)
    {
        double maximo = salario < 4500 ? salario : 4500;
        double imposto = ((maximo - 3000) * (18.0 / 100.0));
        impostoTotal += imposto;
    }

    if (salario >= 4500.01)
    {
        double imposto = ((salario - 4500) * (28.0 / 100.0));
        impostoTotal += imposto;
    }

    return impostoTotal;
}
