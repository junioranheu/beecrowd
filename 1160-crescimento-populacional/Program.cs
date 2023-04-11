// https://www.beecrowd.com.br/judge/pt/problems/view/1160
int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    int PA = int.Parse(input[0]); // País #1;
    int PB = int.Parse(input[1]); // País #2;
    double G1 = double.Parse(input[2]); // Crescimento populacional do país #1 em porcentagem;
    double G2 = double.Parse(input[3]); // Crescimento populacional do país #2 em porcentagem;

    int qtdAnosPara_PA_Ultrapassar_PB = 0;

    while (true)
    {
        qtdAnosPara_PA_Ultrapassar_PB++; // Iterar a quantida de anos;

        // Calcular resultados para realizar comparação posteriormente;
        int resultadoPA = Convert.ToInt32(Math.Floor(PA * (G1 / 100)));
        int resultadoPB = Convert.ToInt32(Math.Floor(PB * (G2 / 100)));

        PA += resultadoPA;
        PB += resultadoPB;

        if ((PA > PB) || (qtdAnosPara_PA_Ultrapassar_PB > 100))
        {
            break;
        }
    }

    if (qtdAnosPara_PA_Ultrapassar_PB <= 100)
    {
        Console.WriteLine($"{qtdAnosPara_PA_Ultrapassar_PB} anos.");
    }
    else
    {
        Console.WriteLine("Mais de 1 seculo.");
    }
}