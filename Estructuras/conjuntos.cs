public static class Conjuntoa{
    public static void Run(){
        
        // definición de conjunto (No acepta repetidos)
        HashSet<int> numeros = new HashSet<int>();
        numeros.Add(3);
        numeros.Add(4);
        numeros.Add(5);
        numeros.Add(6);
        numeros.Add(7);
        numeros.Add(8);
        numeros.Add(9);

        HashSet<int> primos = new HashSet<int>();
        primos.Add(1);
        primos.Add(3);
        primos.Add(5);
        primos.Add(7);
        primos.Add(11);

        //Union
        HashSet<int> conjunto = new HashSet<int>();
        //numeros.IntersectWith(primos);

        conjunto.UnionWith(numeros);
        conjunto.UnionWith(primos);

        foreach (var item in conjunto)
        {
            System.Console.WriteLine(item);
        }
    }
}