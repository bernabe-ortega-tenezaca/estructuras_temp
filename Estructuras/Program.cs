Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("Estructura de datos");
Console.WriteLine();

//Diccionario de estudiantes
Dictionary<int, string> estudiantes = new Dictionary<int, string>();
estudiantes.Add(1,"Ana");
estudiantes.Add(2, "José");

// Error al repetir la clave(key)
//estudiantes.Add(2,"Arturo");
// try
// {
//     estudiantes.Add(2,"Arturo");
// }
// catch (System.Exception e)
// {
//     System.Console.WriteLine("Ha ocurrido un error, contáctese con el administrador: " + e.Message);
// }

//Diccionario español - inglés
Dictionary<string, string> diccionario = new Dictionary<string, string>();
diccionario.Add("dia","day");
diccionario.Add("noche","night");
diccionario.Add("paz","peace");
//continuar con 10 palabras mínimo

//diccionario["noche"] = "Night"; //actualizar un valor


string frase = "Noche de paz, noche de amor, todo brilla"; //Noche de peace, night de amor, todo brilla
string[] palabras = frase.Split(" ");

if (diccionario.ContainsKey("de"))
{
    System.Console.WriteLine("de:  ha sido encontrado");
} else{
    //System.Console.WriteLine("un: NO ha sido registrado");
    diccionario.Add("de", "of");
}


// System.Console.WriteLine(frase);
foreach (var item in palabras) //Item recorre cada una de las palabras de la frase  
{
    if(diccionario.ContainsKey(item)){
        System.Console.WriteLine(diccionario[item]);
    } else{
        System.Console.WriteLine(item);
    }
}

//Menú
//1. Ingrese la frase
//2. Agregar palabras al diccionario
    //ingrese la palabra
    //ingrese la traducción
//3. Salir