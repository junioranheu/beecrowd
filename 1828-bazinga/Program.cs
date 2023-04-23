// https://www.beecrowd.com.br/judge/pt/problems/view/1828
int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] entrada = Console.ReadLine().Split(' ');
    string sheldon = entrada[0];
    string raj = entrada[1];

    Console.WriteLine($"Caso #{(i + 1)}: {GerarResultado(sheldon, raj)}");
}

static string GerarResultado(string sheldon, string raj)
{
    if (sheldon == raj)
    {
        return "De novo!";
    }

    if (
            (sheldon == "tesoura" && raj == "papel") ||
            (sheldon == "papel" && raj == "pedra") ||
            (sheldon == "pedra" && raj == "lagarto") ||
            (sheldon == "lagarto" && raj == "Spock") ||
            (sheldon == "Spock" && raj == "tesoura") ||
            (sheldon == "tesoura" && raj == "lagarto") ||
            (sheldon == "lagarto" && raj == "papel") ||
            (sheldon == "papel" && raj == "Spock") ||
            (sheldon == "Spock" && raj == "pedra") ||
            (sheldon == "pedra" && raj == "tesoura")
        )
    {
        return "Bazinga!";
    }
    else
    {
        return "Raj trapaceou!";
    }
}