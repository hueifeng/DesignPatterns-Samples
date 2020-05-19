//using System;
//namespace PubSubPattern1
//{
//    public class Pub
//    {
//        public event Action OnChange = delegate { };

//        public void Raise() {
//            OnChange();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args) {
//            Pub p = new Pub();
//            p.OnChange += () => Console.WriteLine("Sub 1");
//            p.OnChange += () => Console.WriteLine("Sub 2");
//            p.Raise();
//            Console.WriteLine("Press enter !");
//            Console.ReadLine();
//        }
//    }
//}
