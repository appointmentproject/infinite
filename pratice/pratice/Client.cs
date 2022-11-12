using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using BaseLib;

namespace Client
{
    class ClientClass
    {
        delegate void SetValueDel(int val);
        delegate int GetValueDel();
        delegate string GetTextDel();
        [STAThread]
        static void Main(string[] args)
        {
            DateTime start = System.DateTime.Now;
            HttpChannel chnl = new HttpChannel();
            ChannelServices.RegisterChannel(chnl);
            BaseRemoteObject bobj = (BaseRemoteObject)Activator.GetObject(typeof(BaseRemoteObject),
                "http://localhost:1237/RemoteObject");
            SetValueDel svd = new SetValueDel(bobj.setValue);
            GetValueDel gvd = new GetValueDel(bobj.getValue);
            GetTextDel gtd = new GetTextDel(bobj.getText);
            Console.WriteLine("Client Calls can start....");
            Console.WriteLine("Set the Value() has been called...");
            svd(5);
            Console.WriteLine("Check the Value thru GetValue()..");
            int retval = gvd();
            Console.WriteLine("The Value that has been set is : {0}", retval);
            Console.WriteLine("Calling the GetText()..");
            string rettext = gtd();
            Console.WriteLine("The Returned text is ..{0}", rettext);
            DateTime end = System.DateTime.Now;
            TimeSpan ts = end.Subtract(start);
            Console.WriteLine("Client : Remote Execution started at {0} and ended at {1}", start, end);
            Console.WriteLine("The Total Time taken for Execution is {0}", ts.Seconds);
            Console.Read();


        }
    }
}