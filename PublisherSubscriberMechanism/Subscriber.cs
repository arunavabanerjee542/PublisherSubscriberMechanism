using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberMechanism
{
    class Subscriber
    {
        Publisher publisher = new Publisher();

        Publish p;


        public async Task CallPublisher()
        {


           // using delegates fails

            /*
            p += Subscriber1GetDataFromPublisher;
            p += Subscriber2GetDataFromPublisher;
            p += Subscriber3GetDataFromPublisher;
            p = null;
            */


            // Thus here We see that a subscriber is able to destroy a publisher hat 
            // should not be allowed in a proper publisher subscriber mechanism
            //this entire thing has a simple solution 
            // USE EVENTS INSTEAD OF DELEGATES 



            // using events works fine

            publisher.Publishing += Subscriber1GetDataFromPublisher;
            publisher.Publishing += Subscriber2GetDataFromPublisher;
            publisher.Publishing += Subscriber3GetDataFromPublisher;
          //  publisher.Publishing = null;   // now this is not allowed 



            await publisher.process();
        }
      

        

        public void Subscriber1GetDataFromPublisher(int i)
        {
            Console.WriteLine(" Publisher Gave Subscriber 1  " + i);
        }

        public void Subscriber2GetDataFromPublisher(int i)
        {
            Console.WriteLine(" Publisher Gave Subscriber 2  " + i);
        }

        public void Subscriber3GetDataFromPublisher(int i)
        {
            Console.WriteLine(" Publisher Gave Subscriber 3  " + i);
        }

    }
}
