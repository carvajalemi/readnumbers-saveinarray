using System;

class Program {
   public static void ImprimirArray(int[] array, int tamanioA)
    {
        for (int i = 0; i < tamanioA; i++)
        {
          int elemento = array[i];
          Console.Write(elemento);
          // Imprimir también una coma solo si no estoy en el ultimo numero
          if (i!=tamanioA-1)
            Console.Write(", ");
            //Console.Write(array[i] +", " );
        }
    }
  
  public static void Main (string[] args) {
    Console.WriteLine ("Por favor ingrese el tamanio del array:");
    string tamanioComoString = Console.ReadLine();    
    // string a int
    int tamanioArray = Int32.Parse(tamanioComoString);
    int[] array = new int[tamanioArray];
    Console.WriteLine ("Por favor ingrese los elementos del array:");
    // llenar los elementos del array
    for (int i = 0; i < tamanioArray; i++)
    {
      string elementoComoString = Console.ReadLine();    
      // string a int
      int elementoArray = Int32.Parse(elementoComoString);
      //aniadimos el valor del elemento
      array[i] = elementoArray;  
      //Console.WriteLine("Array posicion: " + i + " Valor del elemento: " + array[i]);
    }
    ImprimirArray(array, tamanioArray);
    return;
  }
}