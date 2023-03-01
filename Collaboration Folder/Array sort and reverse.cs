// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Negative right, Positive left");
        sortArray();
        
        Console.WriteLine("Positive right, Negative left");
        reverseArray();
    }
    
    private static void sortArray() {
        int[] array = { 10, 11, 99, 5, -20, -6, -1, -2 };
        
        Array.Sort(array);
        foreach(int x in array) {
            Console.Write(x + " ");
        }
        
        Console.WriteLine(".....");
        

    }
    
     private static void reverseArray() {
         int[] array = { 10, 11, 99, 5, -20, -6, -1, -2 };
        
        Array.Sort(array);
        Array.Reverse(array);
        foreach(int x in array) {
            Console.Write(x + " ");
        }
        
        Console.WriteLine(".....");
        
    }
}