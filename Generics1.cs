
namespace Generics1;


// C# program to show multiple
// type parameters in Generics
using System;
 
public class GFG {
     
    // Generics method
    public void Display<TypeOfValue>(string msg, TypeOfValue value)
    {
        Console.WriteLine("{0}:{1}", msg, value);
    }
}
 
// Driver class
public class Example2 {
     
    // Main Method
    public static int Main_Generics1()
    {
         
        // creating object of class GFG
        GFG p = new GFG();
         
        // calling Generics method
        p.Display<int>("Integer", 122);
        p.Display<char>("Character", 'H');
        p.Display<double>("Decimal", 255.67);
        return 0;
    }
}