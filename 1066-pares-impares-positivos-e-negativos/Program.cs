// https://www.beecrowd.com.br/judge/pt/problems/view/1066
const int qtdLoop = 5;
int par = 0, impar = 0, positivo = 0, negativo = 0;

for (int i = 0; i < qtdLoop; i++)
{
    int n = int.Parse(Console.ReadLine());

    par = Par(par, n);
    impar = Impar(impar, n);
    positivo = Positivo(positivo, n);
    negativo = Negativo(negativo, n);
}

Console.WriteLine($"{par} valor(es) par(es)");
Console.WriteLine($"{impar} valor(es) impar(es)");
Console.WriteLine($"{positivo} valor(es) positivo(s)");
Console.WriteLine($"{negativo} valor(es) negativo(s)");

static int Par(int par, int n)
{
    if (n % 2 == 0)
    {
        return par + 1;
    }

    return par;
}

static int Impar(int impar, int n)
{
    if (n % 2 != 0)
    {
        return impar + 1;
    }

    return impar;
}

static int Positivo(int positivo, int n)
{
    if (n > 0)
    {
        return positivo + 1;
    }

    return positivo;
}

static int Negativo(int negativo, int n)
{
    if (n < 0)
    {
        return negativo + 1;
    }

    return negativo;
}