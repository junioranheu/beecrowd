// https://www.beecrowd.com.br/judge/pt/problems/view/1142
int j = int.Parse(Console.ReadLine());
int pum = 1;

for (int i = 0; i < j; i++)
{
    Console.WriteLine($"{pum} {pum + 1} {pum + 2} PUM");
    pum += 4;
}