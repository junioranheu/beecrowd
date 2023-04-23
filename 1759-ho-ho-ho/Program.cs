// https://www.beecrowd.com.br/judge/pt/problems/view/1759
using System.Text;

int N = int.Parse(Console.ReadLine());
StringBuilder ho = new StringBuilder();

for (int i = 0; i < N; i++)
{
    ho.Append("Ho ");
}

Console.WriteLine($"{ho.Remove(ho.Length - 1, 1)}!");