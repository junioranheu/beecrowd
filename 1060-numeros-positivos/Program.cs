// https://www.beecrowd.com.br/judge/pt/problems/view/1060
double valor1 = double.Parse(Console.ReadLine());
double valor2 = double.Parse(Console.ReadLine());
double valor3 = double.Parse(Console.ReadLine());
double valor4 = double.Parse(Console.ReadLine());
double valor5 = double.Parse(Console.ReadLine());
double valor6 = double.Parse(Console.ReadLine());

double[] valores = new double[] { valor1, valor2, valor3, valor4, valor5, valor6 };

Console.WriteLine($"{ChecarPositivos(valores)} valores positivos");

static int ChecarPositivos(double[] valores)
{
    int positivos = 0;

    for (int i = 0; i < valores.Length; i++)
    {
        if (valores[i] >= 0)
        {
            positivos++;
        }
    }

    return positivos;
}