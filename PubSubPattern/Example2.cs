//using System;
//namespace PubSubPattern2
//{
//    public class Example2
//    {
//        public class MyEventArgs : EventArgs
//        {
//            public int Value { get; set; }

//            public MyEventArgs(int value) {
//                Value = value;
//            }
//        }

//        public class Pub
//        {
//            public event EventHandler<MyEventArgs> OnChange = delegate { };
//            public void Raise() {
//                OnChange(this, new MyEventArgs(1));
//            }
//        }
//        class Program {
//            static void Main(string[] args) {
//                Pub p = new Pub();
//                p.OnChange += (sender, e) => Console.WriteLine("Sub 1.Value:"+e.Value);
//                p.OnChange += (sender, e) => Console.WriteLine("Sub 2.Value:"+e.Value);
//                p.Raise();
//                Console.WriteLine("Press enter !");
//                Console.ReadLine();
//            }
//        }
//    }
//}
