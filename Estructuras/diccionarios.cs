public static class diccionario{
    public static void run(){
        Console.WriteLine("======== Diccionario =============");

//inglés, español
Dictionary<string, string> traductor = new Dictionary<string, string>();

//Método 1
// traductor.Add("hola", "hello");
// traductor.Add("dia", "day");
// traductor.Add("un", "a");

String? linea;
string[] aux;
//Método 2
try
{
    StreamReader lector = new StreamReader("diccionario.csv");
    linea = lector.ReadLine();
    while(linea !=null){
        aux = linea.Split(";");
        traductor.Add(aux[0],aux[1]);
        linea = lector.ReadLine();
    }
}
catch (System.Exception e)
{
    System.Console.WriteLine("Ha ocurrido un error: " + e.Message);
}

foreach (var item in traductor)
{
    System.Console.WriteLine(item);
}




// string frase = "hoy dia es jueves, un gusto saludarte";

// string[] palabras = frase.Split(" ");
// string resultado;

// foreach (var item in palabras)
// {
//     if(traductor.ContainsKey(item)){
//         System.Console.WriteLine($"{item} - {traductor[item]}");
//     } else{
//         System.Console.WriteLine($"{item} - no encontrado");
//     }
// }




// HashSet<string> ciudadanos = new HashSet<string>();
// ciudadanos.Add("Anita Guevara");
// ciudadanos.Add("Carla Salas");
// for (int i = 1; i <=500; i++)
// {
//     ciudadanos.Add("ciudadano " + i);
// }

// Random aleatorio = new Random();

// HashSet<string> covid = new HashSet<string>();
// while (covid.Count < 75){
//     covid.Add("ciudadano " + aleatorio.Next(3000));
// }

// foreach (var item in covid)
// {
//     System.Console.WriteLine(item);
// }





// foreach (var item in ciudadanos)
// {
//     Console.WriteLine(item);
// }






// //escribir codigo para leer desde teclado
// int minumero = 3;



// Console.WriteLine("El número ingresado es: " + minumero); // concatenando un mensaje y el valor de una variable 
// System.Console.WriteLine($"El número ingresado es: {minumero}");
// System.Console.WriteLine("El número ingresado es {0} y si sumo 4 me dan {1}, recuerde que el valor fue {2}", minumero, minumero+4, minumero);
// Console.WriteLine();

//Crear una colección de datos
// List<string> estudiantes = new List<string>();
// List<int> edades = new List<int>();

// estudiantes.Add("Jorge");
// estudiantes.Add("Ana");
// edades.Add(1);
// edades.Add(10);


// foreach (string nombre in estudiantes) //nombre es la variable de tipo string que recorre la collection estudiantes
// {
//     System.Console.WriteLine(nombre);
// }

// foreach (int numero in edades)
// {
//     System.Console.WriteLine(numero);
// }

// foreach (var item in estudiantes)
// {
//     System.Console.WriteLine(item);
// }















//System.Console.WriteLine("Universidad Estatal Amazónica");

// HashSet<string> ciudadanos = new HashSet<string>(); //500
// HashSet<string> astraseneca = new HashSet<string>(); //100
// HashSet<string> pfizer = new HashSet<string>(); //50

// //metodo 3
// String? linea;

// try
// {
//     StreamReader lector = new StreamReader("basedatos.txt");
//     linea = lector.ReadLine();

//     while(linea != null){
//         //System.Console.WriteLine(linea);
//         ciudadanos.Add(linea);    
//         linea = lector.ReadLine();
//     }
// }
// catch (System.Exception error)
// {
//     System.Console.WriteLine("Ha ocurrido un error: " + error.Message);
// }

// //imprimir la colección ciudadanos
// foreach (var item in ciudadanos)
// {
//     System.Console.WriteLine(item);
// }




















// // metodo 1
// for (int i = 0; i < 500; i++)
// {
//     //System.Console.WriteLine();
//     ciudadanos.Add("ciudadano " + (i + 1));
// }

// for (int j = 1; j < 101; j++)
// {
//     astraseneca.Add("ciudadano " + j);
// }

// for (int i = 1; i <= 500; i++)
// {
//     pfizer.Add("ciudadano " + i);
// }














// //Metodo 2
// Random aleatorio = new Random();

// for (int i = 0; i < 500; i++)
// {
//     //System.Console.WriteLine(aleatorio.Next(1,25));
//     ciudadanos.Add("ciudadano " + aleatorio.Next(1,2000));    
// }































// HashSet<string> ciudadanos = new HashSet<string>(); 

// String? linea;

// try
// {
//     StreamReader lector = new StreamReader("nombres.txt");
//     linea = lector.ReadLine();
//     while (linea != null)
//     {
//         //System.Console.WriteLine(linea);
//         ciudadanos.Add(linea);
//         linea = lector.ReadLine();
//     }
// }
// catch (System.Exception error)
// {
//     System.Console.WriteLine("Ha ocurrido un error: " + error);
// }





// // imprimir la colección ciudadanos
// foreach (var item in ciudadanos)
// {
//     System.Console.WriteLine(item);
// }

//metodo 1 para generar nombres
// for (int i = 0; i < 500; i++)
// {
//     // System.Console.WriteLine("ciudadano " + i);
//     ciudadanos.Add("ciudadano " + i);
// }


// //metodo 2
// Random aleatorio = new Random();

// for (int i = 0; i < 500; i++)
// {
//     //System.Console.WriteLine(aleatorio.Next(1,10));
//     ciudadanos.Add("ciudadano " + aleatorio.Next(1,1000));
// }


























// System.Console.WriteLine();
// Console.WriteLine("    Clase encuentro Jueves");
// Console.WriteLine();

// String? linea;
// HashSet<string> ciudadanos = new HashSet<string>();

// // metodo 3
// try
// {
//     StreamReader lector = new StreamReader("nombres.txt");
//     linea = lector.ReadLine();  // linea = a la primera linea
//     while (linea != null)
//     {
//         //System.Console.WriteLine(linea);
//         ciudadanos.Add(linea);
//         linea = lector.ReadLine();
//     }
//     lector.Close();
// }
// catch (System.Exception ex)//capturar el error en una variable ex
// {
//     System.Console.WriteLine("Ha ocurrido un error " + ex.Message);
// }

// foreach (var item in ciudadanos)
// {
//     System.Console.WriteLine(item);
// }






//Generar nombres ficticios método 1
// for (int i = 0; i < 500; i++)
// {
//     //Console.WriteLine("persona " + (i + 1));
//     //ciudadanos.Add("nombre " + (i+1) + " " + "apellido " + (i + 1));
//     ciudadanos.Add("persona " + (i + 1));
// }

// foreach (var item in ciudadanos)
// {
//     System.Console.WriteLine(item);
// }

// Random aleatorio = new Random(); //Definir numeros aleatorios (al azar)

// for (int i = 0; i < 500; i++)
// {
//     //System.Console.WriteLine( aleatorio.Next(1,10)); //imprima numeros entre el 1 y el 10
//     ciudadanos.Add("persona " + aleatorio.Next(1,100));
// }

// foreach (var item in ciudadanos)
// {
//     System.Console.WriteLine(item);
// }
    }
}