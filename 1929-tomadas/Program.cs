// https://www.beecrowd.com.br/judge/pt/problems/view/1930
string[] entrada = Console.ReadLine().Split(' ');
int T1 = int.Parse(entrada[0]); 
int T2 = int.Parse(entrada[1]);
int T3 = int.Parse(entrada[2]);
int T4 = int.Parse(entrada[3]);
int T = T1 + T2 + T3 + T4 - 3;

Console.WriteLine(T);