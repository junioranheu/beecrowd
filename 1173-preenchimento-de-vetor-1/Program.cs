// https://www.beecrowd.com.br/judge/pt/problems/view/1173
int[] N = new int[10];

N[0] = int.Parse(Console.ReadLine()); 

for (int i = 0; i < N.Length; i++)
{
    try
    {
        int anterior = N[i - 1];
        N[i] = anterior * 2;
    }
    catch (Exception)
    {

    }
}

for (int i = 0; i < N.Length; i++)
{
    Console.WriteLine($"N[{i}] = {N[i]}");
}