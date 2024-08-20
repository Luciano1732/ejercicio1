using Problema1;
using System;


Cola Cola = new Cola();

Cola.Anadir("Elemento 1");
Cola.Anadir("Elemento 2");
Cola.Anadir("Elemento 3");

Console.WriteLine("Primer elemento: " + Cola.Primero());
Console.WriteLine("Elemento extraído: " + Cola.Extraer());
Console.WriteLine("Elemento extraído: " + Cola.Extraer());

Console.WriteLine("Primer elemento después de extracciones: " + Cola.Primero());

Console.WriteLine("¿Está vacía la cola? " + (Cola.EstaVacia() ? "Sí" : "No"));

Console.WriteLine("Elemento extraído: " + Cola.Extraer());

Console.WriteLine("¿Está vacía la cola ahora? " + (Cola.EstaVacia() ? "Sí" : "No"));



Pila Pila = new Pila();

Pila.Anadir("Elemento 1");
Pila.Anadir("Elemento 2");
Pila.Anadir("Elemento 3");

Console.WriteLine("Primer elemento (último agregado): " + Pila.Primero());

Console.WriteLine("Elemento extraído: " + Pila.Extraer());
Console.WriteLine("Elemento extraído: " + Pila.Extraer());

Console.WriteLine("Primer elemento después de extracciones: " + Pila.Primero());

Console.WriteLine("¿Está vacía la pila? " + (Pila.EstaVacia() ? "Sí" : "No"));

Console.WriteLine("Elemento extraído: " + Pila.Extraer());

Console.WriteLine("¿Está vacía la pila ahora? " + (Pila.EstaVacia() ? "Sí" : "No"));
