// https://www.beecrowd.com.br/judge/pt/problems/view/1959
using System;
using System.Collections.Generic;
using System.Linq;

List<long> entrada = Console.ReadLine().Trim().Split(' ').Select((x) => long.Parse(x)).ToList();
Console.WriteLine(entrada[0] * entrada[1]);