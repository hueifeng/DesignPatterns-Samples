using System;
using System.Collections.Generic;
using System.Linq;

namespace PubSubPattern
{
    public class Example4
    {
        public class MyEventArgs : EventArgs
        {
            public int Value { get; set; }

            public MyEventArgs(int value)
            {
                Value = value;
            }
        }

        public class Pub
        {

            public event EventHandler<MyEventArgs> OnChange = delegate { };

            public void Raise()
            {
                MyEventArgs eventArgs = new MyEventArgs(1);

                List<Exception> exceptions = new List<Exception>();

                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, eventArgs);
                    }
                    catch (Exception e)
                    {
                        exceptions.Add(e);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Pub p = new Pub();
                p.OnChange += (sender, e) => Console.WriteLine("Sub 1.Value:" + e.Value);
                p.OnChange += (sender, e) => { throw new Exception(); };
                p.OnChange += (sender, e) => Console.WriteLine("Sub 2.Value:" + e.Value);
                p.Raise();
                Console.WriteLine("Press enter !");
                Console.ReadLine();
            }
        }
    }
}
