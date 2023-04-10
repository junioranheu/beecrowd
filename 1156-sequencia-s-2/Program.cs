// https://www.beecrowd.com.br/judge/pt/problems/view/1156
double S = 1.0;

double primeiro = 3.0;
double segundo = 2.0;

while (primeiro <= 39)
{
    S += (primeiro / segundo);

    primeiro += 2;
    segundo *= 2;
}

Console.WriteLine($"{S:F2}");