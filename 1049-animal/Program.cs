// https://www.beecrowd.com.br/judge/pt/problems/view/1049
string grupo = Console.ReadLine();
string classe = Console.ReadLine();
string caracteristica = Console.ReadLine();

if (grupo == "vertebrado")
{
    if (classe == "ave")
    {
        if (caracteristica == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else if (caracteristica == "onivoro")
        {
            Console.WriteLine("pomba");
        }
    }
    else if (classe == "mamifero")
    {
        if (caracteristica == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else if (caracteristica == "herbivoro")
        {
            Console.WriteLine("vaca");
        }
    }
}
else if (grupo == "invertebrado")
{
    if (classe == "inseto")
    {
        if (caracteristica == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        else if (caracteristica == "herbivoro")
        {
            Console.WriteLine("lagarta");
        }
    }
    else if (classe == "anelideo")
    {
        if (caracteristica == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else if (caracteristica == "onivoro")
        {
            Console.WriteLine("minhoca");
        }
    }
}