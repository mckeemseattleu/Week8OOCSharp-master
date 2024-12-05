namespace Week8OOCSharp;

public class Driver
{
    // Calling Generics1
    static void Main(string[] args)
    {
        // Simple Example of a Generic
        Console.WriteLine(("DI Example\n"));
        DI.DI.constructor.Main_DI();
        Console.WriteLine("Generics1\n");
        Generics1.Example2.Main_Generics1();
        Console.WriteLine("Generics2\n");        
        Generics2.Test.Main_Generics2();
        Console.WriteLine("C# Interface1.  Abstract and an Interface\n"); 
        Interface1.GFG.Main_GFG();
        Console.WriteLine("C# Interface2.  Multi Inheritances\n");
        Multi2.Multi2.GFG.Main_Multi2();
        Console.WriteLine("C# factory for shapes\n");
        ShapeFactory.Program1.Main_poly();
        Console.WriteLine("Penguin (Liskov)\n");
        Penguin.Penguin_liskov.Main_Penguin();   
        Console.WriteLine("Penguin: Good class design\n");
        PenguinFixed.PenguinFixed.Main_pfix();
        
        JSONExample.Program_WeatherForecast.Main_Weather();
        
        SQLiteDemo.Program.Main_Sqlite();
    }
}