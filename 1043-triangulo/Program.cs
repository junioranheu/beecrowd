// https://www.beecrowd.com.br/judge/pt/problems/view/1043
string[] valores = Console.ReadLine().Split(' ');

double A = double.Parse(valores[0]);
double B = double.Parse(valores[1]);
double C = double.Parse(valores[2]);

// Verificar se é um triângulo;
// Só irá existir um triângulo se, somente se...
// Um de seus lados deve ser maior que o valor absoluto da diferença dos outros dois lados...
// E menor que a soma dos outros dois lados;
bool primeiraCondicao = (A > (B - C));
bool segundaCondicao = (A < (B + C));
bool isTriangulo = primeiraCondicao && segundaCondicao;

// 6,0 4,0 2,0
if (isTriangulo)
{
    double perimetroTriangulo = A + B + C;
    Console.WriteLine($"Perimetro = {perimetroTriangulo:F1}");
}
else
{
    // soma das bases vezes a altura dividido por dois
    double areaTrapezio = ((A + B) * C) / 2;
    Console.WriteLine($"Area = {areaTrapezio:F1}");
}