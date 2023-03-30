// https://www.beecrowd.com.br/judge/pt/problems/view/1118
int cont = 0;
double somaTotal = 0;
bool isContinuarLoop = true;

while (isContinuarLoop)
{
    double nota = double.Parse(Console.ReadLine());

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("nota invalida");
        continue;
    }

    cont++;
    somaTotal += nota;

    if (cont == 2)
    {
        Console.WriteLine($"media = {(somaTotal / cont):F2}");
        int resp = 0;

        while (resp != 1 && resp != 2)
        {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            resp = int.Parse(Console.ReadLine());

            if (resp == 1)
            {
                cont = 0;
                somaTotal = 0;
                isContinuarLoop = true;
            } else
            {
                isContinuarLoop = false;
            }          
        }
    }
}