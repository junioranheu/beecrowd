// https://www.beecrowd.com.br/judge/pt/problems/view/1008
int numeroFuncionario = Convert.ToInt32(Console.ReadLine());
int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
double valorHora = Convert.ToDouble(Console.ReadLine());
double salario = horasTrabalhadas * valorHora;

Console.WriteLine($"NUMBER = {numeroFuncionario}");
Console.WriteLine($"SALARY = U$ {salario:F2}");

