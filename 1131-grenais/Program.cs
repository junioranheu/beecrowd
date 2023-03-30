// https://www.beecrowd.com.br/judge/pt/problems/view/1131
int totalLoops = 0, totalGolsInter = 0, totalGolsGremio = 0, totalEmpates = 0;

while (true)
{
    totalLoops++;

    string[] respostas = Console.ReadLine().Split(' ');
    int golsInter = int.Parse(respostas[0]);
    int golsGremio = int.Parse(respostas[1]);

    if (golsInter > golsGremio)
    {
        totalGolsInter++;
    }
    else if (golsGremio > golsInter)
    {
        totalGolsGremio++;
    }
    else
    {
        totalEmpates++;
    }

    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    int respContinuar = int.Parse(Console.ReadLine());

    if (respContinuar == 2)
    {
        break;
    }
}

Console.WriteLine($"{totalLoops} grenais");
Console.WriteLine($"Inter:{totalGolsInter}");
Console.WriteLine($"Gremio:{totalGolsGremio}");
Console.WriteLine($"Empates:{totalEmpates}");

bool isMaisEmpates = totalEmpates > totalGolsInter && totalEmpates > totalGolsGremio;
string msgFinal = isMaisEmpates ? "Nao houve vencedor" : totalGolsInter > totalGolsGremio ? "Inter venceu mais" : "Gremio venceu mais";

Console.WriteLine(msgFinal);