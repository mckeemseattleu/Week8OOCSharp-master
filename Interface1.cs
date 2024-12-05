//https://www.geeksforgeeks.org/c-sharp-inheritance-in-interfaces/
namespace Interface1;
using System;

// C# program to illustrate the concept
// of inheritance in the interface

// Good breakout -
// 1. To create another Subtype of Votes
// 2. Add data to subtype
// 3. 
// 3. To add a function to be implemented that will
//    throw exception when it can't be implemented

// declaring an interface
public interface Votes 
{
    
    // method of interface 
    void vote_no(int a);
}

// The methods of interface Votes
// is inherited into interface Details
public interface Details : Votes 
{
    
    // method of interface Details
    void detailsofauthor(string n, int p);
    
}

// Below class is inheriting 
// the interface Details
// This class must implement 
// the methods of both interface
// i.e. Votes and Details
class TechnicalScriptWriter : Details 
{

    // implementing the method 
    // of interface Votes
    public void vote_no(int a)
    {
        Console.WriteLine("Total number of votes is: {0}", a);
    }
    
    // implementing the method 
    // of interface Details 
    public void detailsofauthor(string n, int p)
    {
        Console.WriteLine("Name of the author is: {0}", n);
        
        Console.WriteLine("Total number of published" + 
                          " article is: {0}", p);
    }
}

// Driver Class
public class GFG {

    // Main method
    public static void Main_GFG()
    {

        // Creating the objects of 
        // TechinalScriptWriter class
        TechnicalScriptWriter obj = new TechnicalScriptWriter();
        
        // calling the methods by passing
        // the required values
        obj.vote_no(470045);
        obj.detailsofauthor("Siya", 98);
        
        // Lets call it via an Interface (Votes)

        Details detail_obj = obj;
        obj.detailsofauthor("Siya", 98);


    }
}
