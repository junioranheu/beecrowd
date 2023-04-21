// https://www.beecrowd.com.br/judge/pt/problems/view/1176
// Sequência de Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233...
int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    int N = int.Parse(Console.ReadLine());
    List<long> listaFibonacci = DescobrirPosicaoFibonacci(N);

    Console.WriteLine($"Fib({N}) = {listaFibonacci[N]}");
}

static List<long> DescobrirPosicaoFibonacci(int N)
{
    long fibonacci = 0, anterior = 0;
    List<long> listaFibonacci = new();
    // string fibonacciFinalStr = "";

    while (true)
    {
        fibonacci += anterior;
        // fibonacciFinalStr += $"{fibonacci}, ";

        // Em um dos primeiros casos, é necessário dar um valor à "anterior" para que aconteça o "arranque" da lógica;
        if (anterior == 0 && fibonacci == 1)
        {
            anterior = 1;
        }
        else
        {
            anterior = fibonacci - anterior; // Em todos os outros casos, "anterior" é calculado exatamente assim;
        }

        // Adicionar número à lista;
        listaFibonacci.Add(fibonacci);

        // Em um dos primeiros casos, é necessário dar um valor à "fibonacci" para que aconteça o "arranque" da lógica;
        if (fibonacci == 0)
        {
            anterior = 1;
        }

        // Aborte o while caso o valor seja o suficiente;
        if (listaFibonacci.Count > N)
        {
            break;
        }
    }

    // Console.WriteLine(fibonacciFinalStr);
    return listaFibonacci;
}