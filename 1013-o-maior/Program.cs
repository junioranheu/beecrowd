// https://www.beecrowd.com.br/judge/pt/problems/view/1013
string[] valores = Console.ReadLine().Split(' ');
int A = Convert.ToInt32(valores[0]);
int B = Convert.ToInt32(valores[1]);
int C = Convert.ToInt32(valores[2]);

int maiorAB = (A + B + Math.Abs(A - B)) / 2;
int maiorMaiorC = (maiorAB+ C + Math.Abs(maiorAB - C)) / 2;

Console.WriteLine($"{maiorMaiorC} eh o maior");