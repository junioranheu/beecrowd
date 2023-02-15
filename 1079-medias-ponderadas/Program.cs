// https://www.beecrowd.com.br/judge/pt/problems/view/1079
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    double valor1 = double.Parse(valores[0]);
    double valor2 = double.Parse(valores[1]);
    double valor3 = double.Parse(valores[2]);

    Console.WriteLine(MediaPonderada(valor1, valor2, valor3));
}

// 6,5 4,3 6,2
// 5,1 4,2 8,1
// 8,0 9,0 10,0
static string MediaPonderada(double valor1, double valor2, double valor3)
{
    double media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / (2 + 3 + 5);
    return $"{media:F1}";
}