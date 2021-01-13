using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberMechanism
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber sub = new Subscriber();

            Task.Factory.StartNew(() => sub.CallPublisher());

            Console.WriteLine(" Program.cs ");

            Console.ReadLine();

        }
    }
}
