// https://www.beecrowd.com.br/judge/pt/problems/view/1847
    string[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);
    int C = int.Parse(valores[2]);

    Console.WriteLine(GerarCarinha(A, B, C));

static string GerarCarinha(int A, int B, int C)
{
    const string FELIZ = ":)";
    const string TRISTE = ":(";
    int diferencaA_B = GerarDiferencaEntreNumerosEAjustarNegativoSeNecessario(A ,B);
    int diferencaB_C = GerarDiferencaEntreNumerosEAjustarNegativoSeNecessario(B, C);

    if ((A > B) && (B < C || B == C)) // Se a temperatura desceu do 1º para o 2º dia, mas subiu ou permaneceu constante do 2º para o 3º, as pessoas ficam felizes (primeira figura).
    {
        return FELIZ;
    }
    else if ((A < B) && (B > C || C == B)) // Se a temperatura subiu do 1º para o 2º dia, mas desceu ou permaneceu constante do 2º para o 3º, as pessoas ficam tristes (segunda figura).
    {
        return TRISTE;
    }
    else if ((A < B && B < C) && (diferencaB_C < diferencaA_B)) // Se a temperatura subiu do 1º para o 2º dia e do 2º para o 3º, mas subiu do 2º para o 3º menos do que subira do 1º para o 2º, as pessoas ficam tristes (terceira figura).
    {
        return TRISTE;
    }
    else if ((A < B && B < C) && (diferencaB_C >= diferencaA_B)) // Se a temperatura subiu do 1º para o 2º dia e do 2º para o 3º, mas subiu do 2º para o 3º no mínimo o tanto que subira do 1º para o 2º, as pessoas ficam felizes (quarta figura).
    {
        return FELIZ;
    }
    else if ((A > B && B > C) && (diferencaB_C < diferencaA_B)) // Se a temperatura desceu do 1º para o 2º dia e do 2º para o 3º, mas desceu do 2º para o 3º menos do que descera do 1º para o 2º, as pessoas ficam felizes (quinta figura).
    {
        return FELIZ;
    }
    else if ((A > B && B > C) && (diferencaB_C >= diferencaA_B)) // Se a temperatura desceu do 1º para o 2º dia e do 2º para o 3º, mas desceu do 2º para o 3º no mínimo o tanto que descera do 1º para o 2º, as pessoas ficam tristes (sexta figura).
    {
        return TRISTE;
    }
    else if ((A == B) && (B < C)) // Se a temperatura permaneceu constante do 1º para o 2º dia, as pessoas ficam felizes se subiu do 2º para o 3º dia ou tristes caso contrário (respectivamente, sétima e oitava figuras).
    {
        return FELIZ;
    }
    else if ((A == B) && (B > C)) // Se a temperatura permaneceu constante do 1º para o 2º dia, as pessoas ficam felizes se subiu do 2º para o 3º dia ou tristes caso contrário (respectivamente, sétima e oitava figuras).
    {
        return TRISTE;
    }

    return TRISTE;
}

static int GerarDiferencaEntreNumerosEAjustarNegativoSeNecessario(int um, int dois)
{
    int diferenca = um - dois;

    if (diferenca< 0)
    {
        return diferenca * -1;
    }

    return diferenca;
}