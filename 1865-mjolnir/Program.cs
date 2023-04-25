// https://www.beecrowd.com.br/judge/pt/problems/view/1865
int C = int.Parse(Console.ReadLine());

for (int i = 0; i < C; i++)
{
    string[] entrada = Console.ReadLine().Split(' ');
    string nome = entrada[0];
    int N = int.Parse(entrada[1]);

    Console.WriteLine(nome == "Thor" ? "Y" : "N");
}