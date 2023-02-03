// https://www.beecrowd.com.br/judge/pt/problems/view/1015
string[] valores1 = Console.ReadLine().Split(' ');
double x1 = double.Parse(valores1[0]);
double y1 = double.Parse(valores1[1]);

string[] valores2 = Console.ReadLine().Split(' ');
double x2 = double.Parse(valores2[0]);
double y2 = double.Parse(valores2[1]);

double final = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"{final:F4}");