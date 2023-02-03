// https://www.beecrowd.com.br/judge/pt/problems/view/1017
const int kmPorLitro = 12;
double tempoGastoViagemEmHoras = int.Parse(Console.ReadLine());
double velocidadeMedia = int.Parse(Console.ReadLine());

double r = (tempoGastoViagemEmHoras * velocidadeMedia) / kmPorLitro;

Console.WriteLine($"{r:F3}");