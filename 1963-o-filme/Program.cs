// https://www.beecrowd.com.br/judge/pt/problems/view/1963
string[] entrada = Console.ReadLine().Split(' ');
double A = double.Parse(entrada[0]);
double B = double.Parse(entrada[1]);

double aumento = ((B - A) / A) * 100;

Console.WriteLine($"{aumento:F2}%");