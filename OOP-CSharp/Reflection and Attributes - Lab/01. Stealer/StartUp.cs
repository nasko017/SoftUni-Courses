using System;
using System.Text;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Type sbType = typeof(StringBuilder);
            //
            //StringBuilder sb = (StringBuilder)Activator.CreateInstance(sbType);
            //
            //StringBuilder sbb=(StringBuilder)Activator.CreateInstance(sbType, new object[] { 10});

            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);

        }
    }
}
