// https://www.beecrowd.com.br/judge/pt/problems/view/1040
string[] numeros = Console.ReadLine().Split(' ');

double A = double.Parse(numeros[0]);
double B = double.Parse(numeros[1]);
double C = double.Parse(numeros[2]);
double D = double.Parse(numeros[3]);

double mediaPonderada = ((A * 2) + (B * 3) + (C * 4) + (D * 1)) / (2 + 3 + 4 + 1);
Console.WriteLine($"Media: {mediaPonderada:F1}");

if (mediaPonderada >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (mediaPonderada >= 5 && mediaPonderada < 7)
{
    Console.WriteLine("Aluno em exame.");
    Exame(mediaPonderada);
}
else if (mediaPonderada < 5)
{
    Console.WriteLine("Aluno reprovado.");
}

static bool Exame(double mediaPonderada)
{
    double notaExame = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {notaExame:F1}");

    double mediaFinal = (notaExame + mediaPonderada) / 2;

    if (mediaFinal >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
    } else
    {
        Console.WriteLine("Aluno reprovado.");
    }

    Console.WriteLine($"Media final: {mediaFinal:F1}");

    return true;
}