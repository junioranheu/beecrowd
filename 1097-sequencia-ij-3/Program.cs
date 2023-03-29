// https://www.beecrowd.com.br/judge/pt/problems/view/1097
int i = 1, j = 7, cont = 1;

while (i <= 9)
{
    Console.WriteLine($"I={i} J={j}");

    cont++;

    j -= 1;

    if (cont > 3)
    {
        cont = 1;
        i += 2;
        j += 5;
    }
}