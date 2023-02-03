// https://www.beecrowd.com.br/judge/pt/problems/view/1012
string[] valores = Console.ReadLine().Split(' ');
double A = Convert.ToDouble(valores[0]);
double B = Convert.ToDouble(valores[1]);
double C = Convert.ToDouble(valores[2]);

double TRIANGULO = (A * C) / 2;
double CIRCULO = 3.14159 * (Math.Pow(C, 2));
double TRAPEZIO = (A + B) * (C / 2);
double QUADRADO = B * B;
double RETANGULO = A * B;

Console.WriteLine($"TRIANGULO: {TRIANGULO:F3}");
Console.WriteLine($"CIRCULO: {CIRCULO:F3}");
Console.WriteLine($"TRAPEZIO: {TRAPEZIO:F3}");
Console.WriteLine($"QUADRADO: {QUADRADO:F3}");
Console.WriteLine($"RETANGULO: {RETANGULO:F3}");
