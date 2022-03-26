string nome, sobrenome, sobrenomeM; 

Console.Write("digite seu nome:");
nome = Console.ReadLine()!;

Console.Write("digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

sobrenomeM = sobrenome.ToUpper();

Console.WriteLine($"nome completo:{nome} {sobrenome}");
Console.WriteLine($"nome em catálogo:{sobrenomeM}, {nome}");
