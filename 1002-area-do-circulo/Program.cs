﻿// https://www.beecrowd.com.br/judge/pt/problems/view/1002
const double n = 3.14159;
double raio = Convert.ToDouble(Console.ReadLine());
double area = n * Math.Pow(raio, 2);

Console.WriteLine($"A={area:F4}");