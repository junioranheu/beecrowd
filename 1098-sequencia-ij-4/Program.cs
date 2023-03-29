// https://www.beecrowd.com.br/judge/pt/problems/view/1098
double i = 0.0, j = 1.0;
int cont = 0, contGeral = 0;

while (i <= 2.0000000000000000000000001)
{
    if (i >= 1.9)
    {
        i = 2.0; // Bug fix;
    }

    Console.WriteLine($"I={NormalizarNumero(i)} J={NormalizarNumero(j)}");

    j++;
    cont++;

    if (cont == 3)
    {
        contGeral++;
        cont = 0;
        i += 0.2;
        j = 1 + (contGeral * 0.2);
    }
}

static string NormalizarNumero(double d)
{
    if ((d % 1) == 0)
    {
        return $"{d:F0}";
    }

    return $"{d:F1}";
}