// https://www.beecrowd.com.br/judge/pt/problems/view/2057
string[] entrada = Console.ReadLine().Split(' ');

int S = int.Parse(entrada[0]);
int T = int.Parse(entrada[1]);
int F = int.Parse(entrada[2]);

Console.WriteLine(GerarResultado(S, T, F));

static int GerarResultado(int saida, int tempoViagem, int fusoHorario)
{
    int horarioChegada = saida + tempoViagem;

    if (horarioChegada > 24)
    {
        horarioChegada = (24 - horarioChegada) * -1;
    }

    int resultadoFinal = horarioChegada + fusoHorario;

    if (resultadoFinal < 0)
    {
        resultadoFinal = 24 + resultadoFinal;
    }

    return resultadoFinal;
}