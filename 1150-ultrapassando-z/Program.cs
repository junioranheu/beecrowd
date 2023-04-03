// https://www.beecrowd.com.br/judge/pt/problems/view/1150
int X = int.Parse(Console.ReadLine());
int Z = int.Parse(Console.ReadLine());

while (X >= Z)
{
    Z = int.Parse(Console.ReadLine());
}

int cont = X;
int contTotal = 0;
int qtdLoopsNecessariosParaChegarDoX_ao_Z = 0;

while (contTotal <= Z)
{
    contTotal += (cont);
    cont++;
    qtdLoopsNecessariosParaChegarDoX_ao_Z++;
}

Console.WriteLine(qtdLoopsNecessariosParaChegarDoX_ao_Z);