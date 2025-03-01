Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("Estructura de datos");
Console.WriteLine();

//Crear un diccionario de estudiantes
Dictionary<int, string> estudiantes = new Dictionary<int, string>();

//Agregar datos
estudiantes.Add(1,"Juan");
estudiantes.Add(2, "María");

// error al ingresar un repetido
//estudiantes.Add(1, "Ana");

int key = 3;
if (estudiantes.ContainsKey(key))
{
    System.Console.WriteLine("El dato ya existe");
}else{
    estudiantes.Add(key, "Ana");
}
//estudiantes.Add(key, "Ana");
// try
// {
//     estudiantes.Add(key, "Ana");
// }
// catch (System.Exception e)
// {
//     System.Console.WriteLine("Ha ocurrido un error: Contacte con el administrador");
// }


//Diccionario espanol ingles
Dictionary<string, string> diccionario = new Dictionary<string, string>();
diccionario.Add("dia", "day");
diccionario.Add("noche", "nigth");
// continuar hasta tener mínimo 10 palabras
// hacer el menú
string frase = "El dia es hermoso, y la noche lluviosa"; // El day es hermoso y la night lluviosa
string[] palabras = frase.Split(" "); //Separamos cada una de las palabras de la frase en un vector

System.Console.WriteLine(frase);
foreach (var item in palabras) //item tendra cada una de las palabras en cada iteracción
{
    if(diccionario.ContainsKey(item)){ // buscamos cada palabra en el diccionario
        System.Console.WriteLine(diccionario[item]);
    }else{
        System.Console.WriteLine(item);
    }
}




//Imprimir el diccionario
// System.Console.WriteLine("Los datos del diccionario son:");
// foreach (var item in estudiantes)
// {
//     System.Console.WriteLine(item);
// }