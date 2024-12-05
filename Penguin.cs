namespace Penguin;

public class Penguin_liskov
{
    public class Bird
    {
        public string Name { get; }

        public Bird(string name)
        {
            Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} eats.");
        }

        public virtual void LayEggs()
        {
            Console.WriteLine($"{Name} lays eggs.");
        }

        public virtual void Fly()
        {
            Console.WriteLine($"{Name} can fly.");
        }

    }

    public class Duck : Bird
    {
        public Duck(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} can fly.");
        }
    }

    public class Kiwi : Bird
    {
        public Kiwi(string name) : base(name)
        {
        }
    }

    public class Penguin : Bird
    {
        public Penguin(string name) : base(name)
        {
        }

        public override void Fly()
        {
            Console.WriteLine($"{Name} cant fly.");
        }
    }

    public static void Main_Penguin()
    {
        // Try to make a Penguin Fly
        Bird birdObj = new Penguin("Pengy");
        birdObj.Fly();
    }
}