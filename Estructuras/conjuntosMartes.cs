public static class ConjuntosMartes{
    public static void run(){
        Console.WriteLine("Semana 9 - Conjuntos Tutoria Martes");
        System.Console.WriteLine("================================");

        //Definir un conjunto llamado miconjunto
        HashSet<string> miconjunto = new HashSet<string>();
        miconjunto.Add("Ana");
        miconjunto.Add("José");
        miconjunto.Add("Ana"); // Los conjuntos no aceptan elementos repetidos

        foreach (var item in miconjunto)
        {
            System.Console.WriteLine(item);
        }

        //Buscar el elemento Ana
        //método 1
        bool encontrado = false;

        encontrado = miconjunto.Contains("ana");
        if(encontrado == true){
            System.Console.WriteLine("El elemento si existe");
        }else{
            System.Console.WriteLine("Elemento no encontrado");
        }

        //Buscar el elemento José
        //métddo 2
        if(miconjunto.Contains("José")){
            System.Console.WriteLine("Encontrado");
        }else{
            System.Console.WriteLine("No encontrado");
        }
    }
}