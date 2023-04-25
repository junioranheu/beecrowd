// https://www.beecrowd.com.br/judge/pt/problems/view/1848
const string grito = "caw caw";
const int qtdMaxGritos = 3;
int qtdGritos = 0;

string[] piscada1 = new string[2] { "--*", "1" };
string[] piscada2 = new string[2] { "-*-", "2" };
string[] piscada3 = new string[2] { "-**", "3" };
string[] piscada4 = new string[2] { "*--", "4" };
string[] piscada5 = new string[2] { "*-*", "5" };
string[] piscada6 = new string[2] { "**-", "6" };
string[] piscada7 = new string[2] { "***", "7" };

int saida = 0;

while (qtdGritos < qtdMaxGritos)
{
    string entrada = Console.ReadLine();

    if (entrada == grito)
    {
        qtdGritos++;

        Console.WriteLine(saida);
        saida = 0;
    }
    else if (entrada == piscada1[0])
    {
        saida += int.Parse(piscada1[1]);
    }
    else if (entrada == piscada2[0])
    {
        saida += int.Parse(piscada2[1]);
    }
    else if (entrada == piscada3[0])
    {
        saida += int.Parse(piscada3[1]);
    }
    else if (entrada == piscada4[0])
    {
        saida += int.Parse(piscada4[1]);
    }
    else if (entrada == piscada5[0])
    {
        saida += int.Parse(piscada5[1]);
    }
    else if (entrada == piscada6[0])
    {
        saida += int.Parse(piscada6[1]);
    }
    else if (entrada == piscada7[0])
    {
        saida += int.Parse(piscada7[1]);
    }
}