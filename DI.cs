namespace DI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
//https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/

public class DI
{
    public interface text
    {
        void print();
    }
    class format : text
    {
        public void print()
        {
            Console.WriteLine(" here is text format");
        }
    }
    // constructor injection
    public class constructorinjection
    {
        private text _text;
        public constructorinjection(text t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }
    public class constructor
    {
        public static void Main_DI()
        {
            constructorinjection cs = new constructorinjection(new format());
            cs.print();
        }
    }
 
}