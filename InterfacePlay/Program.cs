namespace InterfacePlay
{
    public class Program
    {
        public interface IPlayable
        {
            void Play();
            void Pause();
            void Stop() //default interface implementation
            {
                Console.WriteLine("Default implementation of STOP");
            }
        }

        static void Main(string[] args)
        {
            DvdPlayer player = new DvdPlayer();

            player.Play();

            player.Pause();

            player.Stop();
        }
    }
}
