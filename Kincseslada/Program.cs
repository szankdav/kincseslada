using KincsesladaLibrary;

namespace Kincseslada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KincsFactory kincsFactory = new KincsFactory();
            List<IKincs> kincsek = new List<IKincs>();
            for (int i = 0; i < 10; i++) 
            {
                kincsek.Add(kincsFactory.Create());
            }

            foreach (IKincs kincs in kincsek)
            {
                Console.WriteLine(kincs.ToString());
            }

            Console.ReadKey();
        }
    }
}
