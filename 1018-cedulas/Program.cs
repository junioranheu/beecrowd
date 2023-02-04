﻿// https://www.beecrowd.com.br/judge/pt/problems/view/1018
int valor = int.Parse(Console.ReadLine());
int valorInicial = valor;

int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0, nota1 = 0;

if (valor >= 100)
{
    nota100 = valor / 100;
    valor -= nota100 * 100;
}

if (valor >= 50)
{
    nota50 = valor / 50;
    valor -= nota50 * 50;
}

if (valor >= 20)
{
    nota20 = valor / 20;
    valor -= nota20 * 20;
}

if (valor >= 10)
{
    nota10 = valor / 10;
    valor -= nota10 * 10;
}

if (valor >= 5)
{
    nota5 = valor / 5;
    valor -= nota5 * 5;
}

if (valor >= 2)
{
    nota2 = valor / 2;
    valor -= nota2 * 2;
}

if (valor >= 1)
{
    nota1 = valor / 1;
    valor -= nota1 * 1;
}

Console.WriteLine(valorInicial);
Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
Console.WriteLine($"{nota1} nota(s) de R$ 1,00");