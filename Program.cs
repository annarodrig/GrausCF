double c, f;

Console.Write("Temperatura em graus °C:");
c = Convert.ToDouble(Console.ReadLine());

f = (c * 1.8) + 32;

Console.Write($"{c}°C equivalem a {f}°F");