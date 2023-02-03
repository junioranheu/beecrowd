// https://www.beecrowd.com.br/judge/pt/problems/view/1011
int raio = Convert.ToInt32(Console.ReadLine());
double pi = 3.14159;
double volume = (4 / 3.0) * pi * (Math.Pow(raio, 3));

Console.WriteLine($"VOLUME = {volume:F3}");