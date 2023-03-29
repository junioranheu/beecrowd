// https://www.beecrowd.com.br/judge/pt/problems/view/1099
int i = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < i; j++)
{
    string[] numeros = Console.ReadLine().Split(' ');
    int X = Convert.ToInt32(numeros[0]);
    int Y = Convert.ToInt32(numeros[1]);

    if (Y < X)
    {
        int jar = X;
        X = Y;
        Y = jar;
    }

    int somaImpares = 0;

    for (int k = X; k < Y; k++)
    {
        if (k % 2 != 0 && k != X && k != Y)
        {
            somaImpares += k;
        }
    }

    Console.WriteLine(somaImpares);
}