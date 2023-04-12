// using System.Linq;

// https://www.beecrowd.com.br/judge/pt/problems/view/1174
double[] A = new double[100];
string valoresMenoresOuIguais_a_10 = string.Empty;
const char separador = ';';

for (int i = 0; i < A.Length; i++)
{
    A[i] = double.Parse(Console.ReadLine());

    if (A[i] <= 10)
    {
        valoresMenoresOuIguais_a_10 += $"{i}{separador}";
    }
}

if (!string.IsNullOrEmpty(valoresMenoresOuIguais_a_10))
{
    string[] valoresMenoresOuIguais_a_10_double = valoresMenoresOuIguais_a_10.Split(separador).ToArray();

    for (int i = 0; i < valoresMenoresOuIguais_a_10_double.Length; i++)
    {
        string valor = valoresMenoresOuIguais_a_10_double[i];

        if (!string.IsNullOrEmpty(valor))
        {
            Console.WriteLine($"A[{int.Parse(valor)}] = {A[int.Parse(valor)]:F1}");
        }
    }
}