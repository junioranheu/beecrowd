// https://www.beecrowd.com.br/judge/pt/problems/view/1045
string[] valores = Console.ReadLine().Split(' ');
double valor1 = double.Parse(valores[0]);
double valor2 = double.Parse(valores[1]);
double valor3 = double.Parse(valores[2]);

// Encontrar o maior dos 3 valores, para ser o A;
var tupla = DefinirValores(valor1, valor2, valor3);
double A = tupla.Item1;
double B = tupla.Item2;
double C = tupla.Item3;

// Exibir resultados finais;
ResultadoUm(A, B, C);
ResultadoDois(A, B, C);

static Tuple<double, double, double> DefinirValores(double valor1, double valor2, double valor3)
{
    double A = 0, B = 0, C = 0;

    if (valor1 >= valor2 && valor1 >= valor3)
    {
        A = valor1;
        B = valor2;
        C = valor3;
    }
    else if (valor2 >= valor1 && valor2 >= valor3)
    {
        A = valor2;
        B = valor1;
        C = valor3;
    }
    else if (valor3 >= valor1 && valor3 >= valor2)
    {
        A = valor3;
        B = valor1;
        C = valor2;
    }

    return Tuple.Create(A, B, C);
}

static bool ResultadoUm(double A, double B, double C)
{
    if (A >= (B + C))
    {
        Console.WriteLine("NAO FORMA TRIANGULO");
    }
    else if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)))
    {
        Console.WriteLine("TRIANGULO RETANGULO");
    }
    else if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
    {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    }
    else if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2)))
    {
        Console.WriteLine("TRIANGULO ACUTANGULO");
    }

    return true;
}

static bool ResultadoDois(double A, double B, double C)
{
    if ((A == B) && (A == C) && (B == C))
    {
        Console.WriteLine("TRIANGULO EQUILATERO");
    }
    else if ((A == B) || (A == C) || (B == C))
    {
        Console.WriteLine("TRIANGULO ISOSCELES");
    }

    return true;
}