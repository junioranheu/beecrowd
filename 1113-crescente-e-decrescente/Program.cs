// https://www.beecrowd.com.br/judge/pt/problems/view/1113
while (true)
{
    string[] numeros = Console.ReadLine().Split(' ');
    int X = int.Parse(numeros[0]);
    int Y = int.Parse(numeros[1]);

    if (X == Y)
    {
        break;
    }

    string resultado = X > Y ? "Decrescente" : "Crescente";
    Console.WriteLine(resultado);
}