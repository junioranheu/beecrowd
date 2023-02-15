// https://www.beecrowd.com.br/judge/pt/problems/view/1070
int x = int.Parse(Console.ReadLine());
const int limite = 6;
int atual = 0;

for (int i = x; i < x * 3; i++)
{
    if ((i % 2 != 0) && atual < limite)
    {
        Console.WriteLine(i);
        atual++;
    }
}