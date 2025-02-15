System.Console.WriteLine("          Universidad Estatal Amazónica");


// definición de conjunto (No acepta repetidos)
HashSet<int> numeros = new HashSet<int>();
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);
numeros.Add(6);
numeros.Add(7);
numeros.Add(8);
numeros.Add(9);
numeros.Add(4);

foreach (var item in numeros)
{
    System.Console.WriteLine(item);
}

