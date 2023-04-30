// https://www.beecrowd.com.br/judge/pt/problems/view/1983
int N = int.Parse(Console.ReadLine());

int melhorMatricula = 0;
double melhorNota = 0.0;

for (int i = 0; i < N; i++)
{
    string[] entrada = Console.ReadLine().Split(' ');
    int matricula = int.Parse(entrada[0]);
    double nota = double.Parse(entrada[1]);

    if (nota > melhorNota)
    {
        melhorNota = nota;
        melhorMatricula = matricula;
    }
}

Console.WriteLine(melhorNota >= 8 ? melhorMatricula.ToString() : "Minimum note not reached");