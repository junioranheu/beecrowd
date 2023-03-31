// https://www.beecrowd.com.br/judge/pt/problems/view/1145
string[] valores = Console.ReadLine().Split(' ');
int X = int.Parse(valores[0]);
int Y = int.Parse(valores[1]);

for (int i = 1; i <= Y; i++)
{
    for (int j = 0; j < X; j++)
    {
        if ((i + j) > Y)
            break;

        Console.Write($"{i + (j * 1)}");

        if (X - j > 1)
            Console.Write(" ");
    }

    Console.Write("\n");
    i += (X - 1); // Normalizar iterador;
}