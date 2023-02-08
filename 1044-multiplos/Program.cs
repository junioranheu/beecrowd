// https://www.beecrowd.com.br/judge/pt/problems/view/1044
string[] valores = Console.ReadLine().Split(' ');

int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);

bool isMutiplo = A % B == 0 || B % A == 0;

Console.WriteLine(isMutiplo ? "Sao Multiplos" : "Nao sao Multiplos");