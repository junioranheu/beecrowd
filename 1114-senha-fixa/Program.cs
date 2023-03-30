// https://www.beecrowd.com.br/judge/pt/problems/view/1114
while (true)
{
    int senha = int.Parse(Console.ReadLine());

    if (senha == 2002)
    {
        Console.WriteLine("Acesso Permitido");
        break;
    }

    Console.WriteLine("Senha Invalida");
}