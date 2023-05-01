// https://www.beecrowd.com.br/judge/pt/problems/view/1984
long n = long.Parse(Console.ReadLine());
char[] split = n.ToString().ToCharArray();   
string reverso = "";

for (long i = split.LongLength; i > 0; i--)
{
    reverso += split[i - 1];
}

Console.WriteLine(reverso);