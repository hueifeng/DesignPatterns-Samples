//using System;

//namespace PubSubPattern
//{
//    public class Pub
//    {
//        public Action OnChange { get; set; }

//        public void Raise()
//        {
//            if (OnChange != null)
//            {
//                //Invoke OnChange Action
//                OnChange();
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var p=new Pub();
//            p.OnChange += () => Console.WriteLine("Sub 1");
           
//            p.OnChange += () => Console.WriteLine("Sub 2");
            
//            p.Raise();
            
//            Console.WriteLine("Press enter !");
//            Console.ReadLine();

//        }
//    }
//}