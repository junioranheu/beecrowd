// https://www.beecrowd.com.br/judge/pt/problems/view/1009
string nomeVendedor = Console.ReadLine() ?? "";
double salarioFixo = Convert.ToDouble(Console.ReadLine());
double totalVendasMesEmReais = Convert.ToDouble(Console.ReadLine());
double bonus = 15;
double total = salarioFixo + (totalVendasMesEmReais * (bonus / 100));

Console.WriteLine($"TOTAL = R$ {total:F2}");