// https://www.beecrowd.com.br/judge/pt/problems/view/1050
Console.WriteLine(ChecarDDD(int.Parse(Console.ReadLine())));

static string ChecarDDD(int ddd)
{
    if (ddd == 61)
    {
        return "Brasilia";
    }
    else if (ddd == 71)
    {
        return "Salvador";
    }
    else if (ddd == 11)
    {
        return "Sao Paulo";
    }
    else if (ddd == 21)
    {
        return "Rio de Janeiro";
    }
    else if (ddd == 32)
    {
        return "Juiz de Fora";
    }
    else if (ddd == 19)
    {
        return "Campinas";
    }
    else if (ddd == 27)
    {
        return "Vitoria";
    }
    else if (ddd == 31)
    {
        return "Belo Horizonte";
    }
    else
    {
        return "DDD nao cadastrado";
    }
}