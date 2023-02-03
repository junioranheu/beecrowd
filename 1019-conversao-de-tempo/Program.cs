// https://www.beecrowd.com.br/judge/pt/problems/view/1019
int valor = int.Parse(Console.ReadLine());

int horasEmSegundos = 60 * 60;
int horas = valor / horasEmSegundos;
valor -= horas * horasEmSegundos;

int minutosEmSegundos = 60;
int minutos = valor / minutosEmSegundos;
valor -= minutos * minutosEmSegundos;

int segundosEmSegundos = 1;
int segundos = valor / segundosEmSegundos;

Console.WriteLine($"{horas}:{minutos}:{segundos}");