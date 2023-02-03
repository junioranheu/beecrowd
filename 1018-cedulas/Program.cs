﻿// https://www.beecrowd.com.br/judge/pt/problems/view/1018
int valor = int.Parse(Console.ReadLine());
int valorInicial = valor;

int nota100 = 0;
int nota50 = 0;
int nota20 = 0;
int nota10 = 0;
int nota5 = 0;
int nota2 = 0;
int nota1 = 0;

while (valor > 0)
{
    if (valor >= 100)
    {
        nota100 = valor / 100;
        valor -= nota100 * 100;
    }
    else if (valor >= 50)
    {
        nota50 = valor / 50;
        valor -= nota50 * 50;
    }
    else if (valor >= 20)
    {
        nota20 = valor / 20;
        valor -= nota20 * 20;
    }
    else if (valor >= 10)
    {
        nota10 = valor / 10;
        valor -= nota10 * 10;
    }
    else if (valor >= 5)
    {
        nota5 = valor / 5;
        valor -= nota5 * 5;
    }
    else if (valor >= 2)
    {
        nota2 = valor / 2;
        valor -= nota2 * 2;
    }
    else if (valor >= 1)
    {
        nota1 = valor / 1;
        valor -= nota1 * 1;
    }
}

Console.WriteLine(valorInicial);
Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
Console.WriteLine($"{nota1} nota(s) de R$ 1,00");