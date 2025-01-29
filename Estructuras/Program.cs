Console.WriteLine("                     Universidad Estatal Amazónica");

Console.WriteLine("Imprimir los elementos de una cola");
//Queue sirve para definir una cola
Queue<string> nombres = new Queue<string>(); //nombres es una colección

nombres.Enqueue("Ana"); // primero en entrar primero en salir  FIFO=>Cola
nombres.Enqueue("Luis");
nombres.Enqueue("Lucia");
nombres.Enqueue("Carlos");

nombres.Dequeue();

foreach (var item in nombres) //foreach recorre todos y cada uno de los elementos de una colección
{
    Console.WriteLine(item);
}



