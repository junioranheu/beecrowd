// https://www.beecrowd.com.br/judge/pt/problems/view/2029
const double PI = 3.14;

while (true)
{
    string volume = Console.ReadLine();
    string diametro = Console.ReadLine();

    if (volume == null || diametro == null)
    {
        break;
    }

    double V = double.Parse(volume);
    double D = double.Parse(diametro);
    D /= 2;

    double area = PI * D * D;
    double altura = V / area;

    Console.WriteLine($"ALTURA = {altura:F2}");
    Console.WriteLine($"AREA = {area:F2}");
}