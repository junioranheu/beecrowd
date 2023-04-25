// https://www.beecrowd.com.br/judge/pt/problems/view/1914
int QT = int.Parse(Console.ReadLine());

for (int i = 0; i < QT; i++)
{
    string[] entrada1 = Console.ReadLine().Split(' ');
    string nome1 = entrada1[0];
    string jogada1 = entrada1[1];
    string nome2 = entrada1[2];
    string jogada2 = entrada1[3];

    string[] entrada2 = Console.ReadLine().Split(' ');
    int num1 = int.Parse(entrada2[0]);
    int num2 = int.Parse(entrada2[1]);
    int soma = num1 + num2; 

    if (soma % 2 == 0 && jogada1 == "PAR")
    {
        Console.WriteLine(nome1);
    } else if (soma % 2 != 0 && jogada1 == "IMPAR")
    {
        Console.WriteLine(nome1);
    }
    else if (soma % 2 == 0 && jogada2 == "PAR")
    {
        Console.WriteLine(nome2);
    }
    else if (soma % 2 != 0 && jogada2 == "IMPAR")
    {
        Console.WriteLine(nome2);
    }
}