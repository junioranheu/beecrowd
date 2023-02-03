// https://www.beecrowd.com.br/judge/pt/problems/view/1006
double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());
double peso1 = 2;
double peso2 = 3;
double peso3 = 5;
double MEDIA = ((A * peso1) + (B * peso2) + (C * peso3)) / (peso1 + peso2 + peso3);
Console.WriteLine($"MEDIA = {MEDIA:F1}");