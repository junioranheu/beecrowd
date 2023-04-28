// https://www.beecrowd.com.br/judge/pt/problems/view/1962
int N = int.Parse(Console.ReadLine());
const int doismilequinze = 2015;

for (int i = 0; i < N; i++)
{
    int A = int.Parse(Console.ReadLine());
 
    if (A >= 2015)
    {
        Console.WriteLine($"{(A - doismilequinze + 1)} A.C.");
    }
    else
    {
        Console.WriteLine($"{(doismilequinze - A)} D.C.");
    }
}