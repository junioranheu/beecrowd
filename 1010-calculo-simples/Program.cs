// https://www.beecrowd.com.br/judge/pt/problems/view/1010
string[] peca1 = Console.ReadLine().Split(' ');
int codigoPeca1 = Convert.ToInt32(peca1[0]);    
int numerosPeca1 = Convert.ToInt32(peca1[1]);
double valorUnitarioPeca1 = Convert.ToDouble(peca1[2]);

string[] peca2 = Console.ReadLine().Split(' ');
int codigoPeca2 = Convert.ToInt32(peca2[0]);
int numerosPeca2 = Convert.ToInt32(peca2[1]);
double valorUnitarioPeca2 = Convert.ToDouble(peca2[2]);

double total = (numerosPeca1 * valorUnitarioPeca1) + (numerosPeca2 * valorUnitarioPeca2);
Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");