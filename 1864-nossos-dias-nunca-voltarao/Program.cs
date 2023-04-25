// https://www.beecrowd.com.br/judge/pt/problems/view/1864
char[] caracteres = "LIFE IS NOT A PROBLEM TO BE SOLVED".ToCharArray();
int N = int.Parse(Console.ReadLine());

if (N > 0 && N <= caracteres.Length)
{
    string msgFinal = string.Empty;

    for (int i = 0; i < N; i++)
    {
        msgFinal += caracteres[i];
    }

    Console.WriteLine(msgFinal);
}