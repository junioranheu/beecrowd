// https://www.beecrowd.com.br/judge/pt/problems/view/2003
string entrada;

while ((entrada = Console.ReadLine()) != null)
{
    int[] numeros = entrada.Trim().Split(':').Select(x => int.Parse(x)).ToArray();

    int total = numeros[0] * 60 + numeros[1];
    Console.WriteLine($"Atraso maximo: {Math.Max(0, total + 60 - 8 * 60)}");
}