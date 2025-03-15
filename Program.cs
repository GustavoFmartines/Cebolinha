string texto;
string textoLeet;

Console.Clear();


Console.WriteLine("Escreve um texto: ");
texto = Console.ReadLine()!;
textoLeet = texto.Replace("R", "L")
                 .Replace("r", "l")
;
Console.WriteLine($"Cebolinha: {textoLeet}");
