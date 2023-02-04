//// https://www.beecrowd.com.br/judge/pt/problems/view/1021
//double valor = double.Parse(Console.ReadLine());

//double nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0,
//       moeda1 = 0, moeda050 = 0, moeda025 = 0, moeda010 = 0, moeda005 = 0, moeda001 = 0;

//// Cédula;
//if (valor >= 100)
//{
//    nota100 = Math.Truncate(valor / 100);
//    valor -= nota100 * 100;
//}

//if (valor >= 50)
//{
//    nota50 = Math.Truncate(valor / 50);
//    valor -= nota50 * 50;
//}

//if (valor >= 20)
//{
//    nota20 = Math.Truncate(valor / 20);
//    valor -= nota20 * 20;
//}

//if (valor >= 10)
//{
//    nota10 = Math.Truncate(valor / 10);
//    valor -= nota10 * 10;
//}

//if (valor >= 5)
//{
//    nota5 = Math.Truncate(valor / 5);
//    valor -= nota5 * 5;
//}

//if (valor >= 2)
//{
//    nota2 = Math.Truncate(valor / 2);
//    valor -= nota2 * 2;
//}

//// Moeda;
//if (valor >= 1)
//{
//    moeda1 = Math.Truncate(valor / 1);
//    valor -= moeda1 * 1;
//}

//if (valor >= 0.50)
//{
//    moeda050 = Math.Truncate(valor / 0.50);
//    valor -= moeda050 * 0.50;
//}

//if (valor >= 0.25)
//{
//    moeda025 = Math.Truncate(valor / 0.25);
//    valor -= moeda025 * 0.25;
//}

//if (valor >= 0.10)
//{
//    moeda010 = Math.Truncate(valor / 0.10);
//    valor -= moeda010 * 0.10;
//}

//if (valor >= 0.05)
//{
//    moeda005 = Math.Truncate(valor / 0.05);
//    valor -= moeda005 * 0.05;
//}

//if (valor >= 0.01)
//{
//    moeda001 = Math.Truncate(valor / 0.01);
//}

//Console.WriteLine("NOTAS:");
//Console.WriteLine($"{nota100} nota(s) de R$ {100:F2}");
//Console.WriteLine($"{nota50} nota(s) de R$ {50:F2}");
//Console.WriteLine($"{nota20} nota(s) de R$ {20:F2}");
//Console.WriteLine($"{nota10} nota(s) de R$ {10:F2}");
//Console.WriteLine($"{nota5} nota(s) de R$ {5:F2}");
//Console.WriteLine($"{nota2} nota(s) de R$ {2:F2}");

//Console.WriteLine("MOEDAS:");
//Console.WriteLine($"{moeda1} moeda(s) de R$ {1:F2}");
//Console.WriteLine($"{moeda050} moeda(s) de R$ {0.5:F2}");
//Console.WriteLine($"{moeda025} moeda(s) de R$ {0.25:F2}");
//Console.WriteLine($"{moeda010} moeda(s) de R$ {0.1:F2}");
//Console.WriteLine($"{moeda005} moeda(s) de R$ {0.05:F2}");
//Console.WriteLine($"{moeda001} moeda(s) de R$ {0.01:F2}");

double dinheiro = double.Parse(Console.ReadLine());
double[] valor = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
int quantidadedenotas;

Console.WriteLine("NOTAS:");
for (int i = 0; i < 6; i++)
{
    quantidadedenotas = (int)(dinheiro / valor[i]);
    Console.WriteLine(quantidadedenotas + " nota(s) de R$ " + valor[i].ToString("0.00"));
    dinheiro -= quantidadedenotas * valor[i];
    dinheiro = Math.Round(dinheiro, 2);
}

Console.WriteLine("MOEDAS:");
for (int i = 6; i < valor.Length; i++)
{
    quantidadedenotas = (int)(dinheiro / valor[i]);
    Console.WriteLine(quantidadedenotas + " moeda(s) de R$ " + valor[i].ToString("0.00"));
    dinheiro -= quantidadedenotas * valor[i];
    dinheiro = Math.Round(dinheiro, 2);
}
