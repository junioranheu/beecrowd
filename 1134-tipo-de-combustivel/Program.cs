// https://www.beecrowd.com.br/judge/pt/problems/view/1134
int alcool = 0, gasolina = 0, diesel = 0;

while (true)
{
    int resp = int.Parse(Console.ReadLine());

    if (resp == 1)
    {
        alcool++;
    }
    else if (resp == 2)
    {
        gasolina++;
    }
    else if (resp == 3)
    {
        diesel++;
    }
    else if (resp == 4)
    {
        break;
    }
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");