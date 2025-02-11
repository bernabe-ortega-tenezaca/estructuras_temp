System.Console.WriteLine("              Universidad Estatal Amazónica");
System.Console.WriteLine();

//ConjuntosMartes.run();
HashSet<int> numeros = new HashSet<int>{1,2,3};
HashSet<string> nombres = new HashSet<string>{"Ana", "Juan", "Pedro"};
HashSet<string> apellidos = new HashSet<string>{"Ana", "Perez", "Tiago"};

nombres.UnionWith(apellidos);

foreach (var item in nombres)
{
    System.Console.WriteLine(item);
}

