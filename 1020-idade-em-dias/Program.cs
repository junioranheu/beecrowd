// https://www.beecrowd.com.br/judge/pt/problems/view/1020
int idadeEmDias = int.Parse(Console.ReadLine());

const int ano = 365;
const int mes = 30;
const int dia = 1;

int anos = 0;
int meses = 0;
int dias = 0;

if (idadeEmDias >= ano)
{
    anos = idadeEmDias / ano;
    idadeEmDias -= ano * anos;
}

if (idadeEmDias >= mes)
{
    meses = idadeEmDias / mes;
    idadeEmDias -= mes * meses;
}

if (idadeEmDias >= dia)
{
    dias = idadeEmDias / dia;
}

Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{meses} mes(es)");
Console.WriteLine($"{dias} dia(s)");

