namespace IntAbsClass
{
    internal class Program
    {
        public interface INOImplementation
        {
            void Alpha(); // måste implementeras av härleda/derived typ
        }

        public interface ISomeImplementation
        {
            void Alpha(); // måste implementeras av härleda/derived typ

            void Beta()
            {
                //default implementation; ska kunna override
            }

        }

        public abstract class  PartialyImplemented 
        {
            public abstract void Gamma(); // måste implementeras av härleda/derived typ

            public virtual void Delta() //ska kunna override
            {
                Console.WriteLine();//implementation 
            }
        }

        public class FullyImplemented : PartialyImplemented, ISomeImplementation
        {
            public void Alpha()
            {
                //implementation
            }
            public override void Gamma()
            {
                //implementation
            }

        }


        static void Main(string[] args)
        {
            FullyImplemented a = new(); // ni kan implementera fullständiga class

            PartialyImplemented b = new(); //Compile error!
            ISomeImplementation c = new(); //Compile error!
            INOImplementation d = new(); //Compile error!
        }
    }
}
