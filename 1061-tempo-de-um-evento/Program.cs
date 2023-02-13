// https://www.beecrowd.com.br/judge/pt/problems/view/1061
//string[] datasInicio = Console.ReadLine().Split(' ');
//string[] datasFim = Console.ReadLine().Split(' ');

//int totalInicio = GerarTotalEmSegundo(int.Parse(datasInicio[0]), int.Parse(datasInicio[1]), int.Parse(datasInicio[2]), int.Parse(datasInicio[3]));
//int totalFim = GerarTotalEmSegundo(int.Parse(datasFim[0]), int.Parse(datasFim[1]), int.Parse(datasFim[2]), int.Parse(datasFim[3]));

//// 5 8 12 23
//// 9 6 13 23
//int totalResultadoEmSegundo = totalFim - totalInicio;
//var resultadoFinal = GerarDataUsandoSegundo(totalResultadoEmSegundo);

//Console.WriteLine($"{resultadoFinal.Item1} dia(s)");
//Console.WriteLine($"{resultadoFinal.Item2} hora(s)");
//Console.WriteLine($"{resultadoFinal.Item3} minuto(s)");
//Console.WriteLine($"{resultadoFinal.Item4} segundo(s)");

//static int GerarTotalEmSegundo(int dia, int hora, int minuto, int segundo)
//{
//    int total = (dia * (24 * 60 * 60));
//    total += (hora * (60 * 60));
//    total += (minuto * 60);
//    total += segundo;

//    return total;
//}

//static Tuple<int, int, int, int> GerarDataUsandoSegundo(int totalResultadoEmSegundo)
//{
//    int dias = totalResultadoEmSegundo / 24 / 60 / 60;
//    totalResultadoEmSegundo -= (dias > 30) ? (30 * 24 * 60 * 60) : (dias * 24 * 60 * 60);

//    int horasDescontar = totalResultadoEmSegundo / 60 / 60;
//    int horas = (horasDescontar > 23) ? 23 : horasDescontar;
//    totalResultadoEmSegundo -= (horasDescontar > 23) ? (23 * 60 * 60) : (horas * 60 * 60);

//    int minutos = totalResultadoEmSegundo / 60;
//    totalResultadoEmSegundo -= (minutos > 59) ? (59 * 60) : (minutos * 60);

//    int segundos = totalResultadoEmSegundo;

//    return Tuple.Create(dias, horas, minutos, segundos);
//}

int DIAT, DIAT2, DIAF, HORAS, HORAS1, HRS, MINUS, MINUS1, MINUST, SEG, SEG1, SEGT, DR, RT, MT;

string[] d = Console.ReadLine().Split(' ');
int DIA = int.Parse(d[1]);

string[] d1 = Console.ReadLine().Split(':');

string[] r = Console.ReadLine().Split(' ');
int DIA1 = int.Parse(r[1]);

string[] v1 = Console.ReadLine().Split(':');

HORAS = int.Parse(d1[0]);
MINUS = int.Parse(d1[1]);
SEG = int.Parse(d1[2]);

HORAS1 = int.Parse(v1[0]);
MINUS1 = int.Parse(v1[1]);
SEG1 = int.Parse(v1[2]);

DIAT = (DIA) * 24 * 60 * 60 + HORAS * 60 * 60 + MINUS * 60 + SEG;
DIAT2 = (DIA1) * 24 * 60 * 60 + HORAS1 * 60 * 60 + MINUS1 * 60 + SEG1;

DR = DIAT2 - DIAT;

DIAF = DR / (24 * 60 * 60);
RT = DR % (24 * 60 * 60);
HRS = RT / (60 * 60);
MT = RT % (60 * 60);
MINUST = MT / 60;
SEGT = MT % 60;

Console.WriteLine(DIAF + " dia(s)");
Console.WriteLine(HRS + " hora(s)");
Console.WriteLine(MINUST + " minuto(s)");
Console.WriteLine(SEGT + " segundo(s)");
