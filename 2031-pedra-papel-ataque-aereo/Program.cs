// https://www.beecrowd.com.br/judge/pt/problems/view/2031
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string jogador1 = Console.ReadLine();
    string jogador2 = Console.ReadLine();

    Console.WriteLine(GerarVencedor(jogador1, jogador2));
}

static string GerarVencedor(string jogador1, string jogador2)
{
    const string ataqueAereo = "ataque";
    const string pedra = "pedra";
    const string papel = "papel";

    const string jogador1Venceu = "Jogador 1 venceu";
    const string jogador2Venceu = "Jogador 2 venceu";
    const string ambosVenceram = "Ambos venceram";
    const string semGanhador = "Sem ganhador";
    const string aniquilacaoMutua = "Aniquilacao mutua";

    if (jogador1 == ataqueAereo && jogador2 == pedra)
    {
        return jogador1Venceu;
    }
    else if (jogador1 == pedra && jogador2 == papel)
    {
        return jogador1Venceu;
    }
    else if (jogador1 == papel && jogador2 == ataqueAereo)
    {
        return jogador2Venceu;
    }

    if (jogador2 == ataqueAereo && jogador1 == pedra)
    {
        return jogador2Venceu;
    }
    else if (jogador2 == pedra && jogador1 == papel)
    {
        return jogador2Venceu;
    }
    else if (jogador2 == papel && jogador1 == ataqueAereo)
    {
        return jogador1Venceu;
    }

    else if (jogador1 == papel && jogador2 == papel)
    {
        return ambosVenceram;
    }
    else if (jogador1 == pedra && jogador2 == pedra)
    {
        return semGanhador;
    }
    else if (jogador1 == ataqueAereo && jogador2 == ataqueAereo)
    {
        return aniquilacaoMutua;
    }
    else
    {
        return string.Empty;
    }
}