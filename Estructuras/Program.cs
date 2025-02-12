System.Console.WriteLine("              Universidad Estatal Amazónica");
System.Console.WriteLine();

//ConjuntosMartes.run();
HashSet<int> numeros = new HashSet<int>{1,2,3};
HashSet<string> nombres = new HashSet<string>{"Ana", "Juan", "Pedro"};
HashSet<string> apellidos = new HashSet<string>{"Ana", "Perez", "Tiago"};

// nombres.UnionWith(apellidos);

// foreach (var item in nombres)
// {
//     System.Console.WriteLine(item);
// }

HashSet<string> auxiliar = new HashSet<string>();// auxiliar no tiene elementos

auxiliar.UnionWith(apellidos); // hago la union de auxiliar con apellidos 
auxiliar.IntersectWith(nombres); // interseccion de auxiliar(apellidos) con los nombres
foreach (var item in auxiliar)
{
    System.Console.WriteLine(item);
}

