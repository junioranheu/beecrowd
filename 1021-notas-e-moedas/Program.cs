// https://www.beecrowd.com.br/judge/pt/problems/view/1021
double valor = Convert.ToDouble(Console.ReadLine());

double nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0,
       moeda1 = 0, moeda050 = 0, moeda025 = 0, moeda010 = 0, moeda005 = 0, moeda001 = 0;

// Cédula;
if (valor >= 100)
{
    nota100 = Math.Truncate(valor / 100);
    valor -= nota100 * 100;
}

if (valor >= 50)
{
    nota50 = Math.Truncate(valor / 50);
    valor -= nota50 * 50;
}

if (valor >= 20)
{
    nota20 = Math.Truncate(valor / 20);
    valor -= nota20 * 20;
}

if (valor >= 10)
{
    nota10 = Math.Truncate(valor / 10);
    valor -= nota10 * 10;
}

if (valor >= 5)
{
    nota5 = Math.Truncate(valor / 5);
    valor -= nota5 * 5;
}

if (valor >= 2)
{
    nota2 = Math.Truncate(valor / 2);
    valor -= nota2 * 2;
}

// Moeda;
if (valor >= 1)
{
    moeda1 = Math.Truncate(valor / 1);
    valor -= moeda1 * 1;
}

if (valor >= 0.50)
{
    moeda050 = Math.Truncate(valor / 0.50);
    valor -= moeda050 * 0.50;
}

if (valor >= 0.25)
{
    moeda025 = Math.Truncate(valor / 0.25);
    valor -= moeda025 * 0.25;
}

if (valor >= 0.10)
{
    moeda010 = Math.Truncate(valor / 0.10);
    valor -= moeda010 * 0.10;
}

if (valor >= 0.05)
{
    moeda005 = Math.Truncate(valor / 0.05);
    valor -= moeda005 * 0.05;
}

if (valor >= 0.01)
{
    moeda001 = Math.Truncate(valor / 0.01);
}

Console.WriteLine("NOTAS:");
Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS:");
Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
Console.WriteLine($"{moeda050} moeda(s) de R$ 0.50");
Console.WriteLine($"{moeda025} moeda(s) de R$ 0.25");
Console.WriteLine($"{moeda010} moeda(s) de R$ 0.10");
Console.WriteLine($"{moeda005} moeda(s) de R$ 0.05");
Console.WriteLine($"{moeda001} moeda(s) de R$ 0.01");