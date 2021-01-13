using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberMechanism
{
    public delegate void  Publish(int i);

    

    public class Publisher
    {
        public event Publish Publishing;

        public async Task process( )
        {
            for(int i=0;i<1000;i++)
            {
                await Task.Delay(1000);
                Publishing(i);


            }


        }


    }
}
