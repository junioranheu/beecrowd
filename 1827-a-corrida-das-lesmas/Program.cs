// https://www.beecrowd.com.br/judge/pt/problems/view/1789
while (true)
{
    string Lstr = Console.ReadLine();

    if (Lstr == null)
    {
        break;
    }

    int L = int.Parse(Lstr);
    string[] listaVelocidadesLesmas = Console.ReadLine().Split(' ');

    int lesmaMaisVeloz = int.Parse(listaVelocidadesLesmas[0]);

    for (int i = 0; i < L; i++)
    {
        if (int.Parse(listaVelocidadesLesmas[i]) > lesmaMaisVeloz)
        {
            lesmaMaisVeloz = int.Parse(listaVelocidadesLesmas[i]);
        }
    }

    Console.WriteLine(DefinirNivelLesma(lesmaMaisVeloz));
}

static int DefinirNivelLesma(int lesmaMaisVeloz)
{
    int nivelLesmaMaisVeloz = 0;

    if (lesmaMaisVeloz < 10)
    {
        nivelLesmaMaisVeloz = 1;
    }
    else if (lesmaMaisVeloz >= 10 && lesmaMaisVeloz < 20)
    {
        nivelLesmaMaisVeloz = 2;
    }
    else if (lesmaMaisVeloz >= 20)
    {
        nivelLesmaMaisVeloz = 3;
    }

    return nivelLesmaMaisVeloz;
}