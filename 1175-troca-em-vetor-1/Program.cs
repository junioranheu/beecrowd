// https://www.beecrowd.com.br/judge/pt/problems/view/1175
int[] N = new int[20];

// Ler;
for (int i = 0; i < N.Length; i++)
{
    N[i] = int.Parse(Console.ReadLine());
}

// Inverter;
int[] jar = new int[N.Length];

for (int i = 0; i < N.Length; i++)
{
    int valorInvertidoN = N[N.Length - (i + 1)];
    jar[i] = valorInvertidoN;
}

// Exibir;
for (int i = 0; i < jar.Length; i++)
{
    Console.WriteLine($"N[{i}] = {jar[i]}");
}