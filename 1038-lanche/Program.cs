// https://www.beecrowd.com.br/judge/pt/problems/view/1038
Object[,] tabela = new Object[,] {
    { 1, "Cachorro quente", 4.00 },
    { 2, "X-salada", 4.50 },
    { 3, "X-bacon", 5.00 },
    { 4, "Torrada simples", 2.00 },
    { 5, "Refrigerante", 1.50 },
};

string[] input = Console.ReadLine().Split(' ');
int codigo = int.Parse(input[0]);
int qtd = int.Parse(input[1]);

for (int i = 0; i < tabela.GetLength(0); i++)
{
    int id = int.Parse(tabela[i, 0].ToString());

    if (codigo == id)
    {
        double preco = double.Parse(tabela[i, 2].ToString());
        double total = qtd * preco;

        Console.WriteLine($"Total: R$ {total:F2}");
    }
}