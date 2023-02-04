// https://www.beecrowd.com.br/judge/pt/problems/view/1036
string[] valores = Console.ReadLine().Split(' ');

double A = double.Parse(valores[0]);
double B = double.Parse(valores[1]);
double C = double.Parse(valores[2]);

double DELTA = Math.Pow(B, 2) - (4 * A * C);

double R1 = (-B + (Math.Sqrt(DELTA))) / ( 2 * A);
double R2 = (-B - (Math.Sqrt(DELTA))) / (2 * A);

if (Double.IsNaN(R1) || Double.IsNaN(R2))
{
    Console.WriteLine("Impossivel calcular");
} else
{
    Console.WriteLine($"R1 = {R1:F5}");
    Console.WriteLine($"R2 = {R2:F5}");
}
