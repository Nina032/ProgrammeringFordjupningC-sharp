using SealedClass;

namespace SealedClass
{
    public abstract class Singer
    {
        public virtual void Sing()
        {
            Console.WriteLine("Singing....");
        }
    }

    public class  LadyGaga : Singer
    {
        public sealed override void Sing() 
        {
            Console.WriteLine("Singing with style...");
        }
    }

    public class Sia : Singer
        public override void Sing()
        {
           
        }
    }

    LadyGaga s1 = new LadyGaga();
}
