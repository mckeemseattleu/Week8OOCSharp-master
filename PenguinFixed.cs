namespace PenguinFixed;

public class PenguinFixed
{
    public interface IRegularBird
    {
        string Name { get; }
        void Eat();
        void LayEggs();
    }

    public interface IFlyingBird
    {
        string Name { get; }
        void Fly();
    }

    public class Bird : IRegularBird
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
    }

    public class FlyingBird : IRegularBird, IFlyingBird
    {
        public string Name { get; }

        public FlyingBird(string name)
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

    public class Kiwi : Bird
    {
        public Kiwi(string name) : base(name)
        {
        }
    }

    public class Duck : FlyingBird
    {
        public Duck(string name) : base(name)
        {
        }
    }
    
    public class Penguin : FlyingBird
    {
        public Penguin(string name) : base(name)
        {
        }
    }
    // HIDE BREAKOUT
    public static int Main_pfix()
    {
        IRegularBird duckObj = new Duck("Donald Duck");
        duckObj.Eat();

        return 0;
    }
}