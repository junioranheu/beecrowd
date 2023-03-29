// https://www.beecrowd.com.br/judge/pt/problems/view/1101
while (true)
{
    string[] numeros = Console.ReadLine().Split(' ');
    int M = Convert.ToInt32(numeros[0]);
    int N = Convert.ToInt32(numeros[1]);

    if (M <= 0 || N <= 0)
    {
        break;
    }

    int menor = M;
    int maior = N;

    if (menor > maior)
    {
        menor = N;
        maior = M;
    }

    string ordemFinal = "";
    int somaFinal = 0;
    for (int i = menor; i <= maior; i++)
    {
        ordemFinal += $"{i} ";
        somaFinal += i;
    }

    Console.WriteLine($"{ordemFinal}Sum={somaFinal}");
}