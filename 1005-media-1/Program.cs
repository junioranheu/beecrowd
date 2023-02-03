// https://www.beecrowd.com.br/judge/pt/problems/view/1005
double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double peso1 = 3.5;
double peso2 = 7.5;
double MEDIA = ((A * peso1) + (B * peso2)) / (peso1 + peso2);

Console.WriteLine($"MEDIA = {MEDIA:F5}");