using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using BaseLib;
using System.Runtime.Remoting.Channels.Http;

namespace RemoteServer
{
    //service class with implementation
    class RemoteServerObject : BaseRemoteObject
    {
        int mvalue;
        public RemoteServerObject()
        {
            Console.WriteLine("Remote Server Object Called... New Instance Created");
        }
        //1.
        public override void setValue(int pvalue)
        {
            Console.WriteLine("RemoteServerObjs old value={0} new value{1}", mvalue, pvalue);
            Console.WriteLine("Waiting for 5 Seconds...");
            Thread.Sleep(5000);
            mvalue = pvalue;
            Console.WriteLine("Value is Set..");
        }
        //2.
        public override int getValue()
        {
            Console.WriteLine("RemoteServer objects getValues()={0}", mvalue);
            return mvalue;
        }

        //3.
        public override string getText()
        {
            Console.WriteLine("RemoteServer.getText() called..");
            Console.WriteLine("Wait for 5 sec..");
            Thread.Sleep(5000);
            Console.WriteLine("Getting you the text..");
            return "Infinites .. dot Net Remoting";
        }
    }
    class Server
    {
        //specify an attribute to have the server running on a single thread
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Server on Port No :1237...");
            HttpChannel channel = new HttpChannel(1237);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerObject), "RemoteObject",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Press any Key to Exit ...");
            Console.Read();
        }
    }
}