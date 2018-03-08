using System;

namespace Recieve
{
	class Program
    {
        static void Main(string[] args)
        {
			Core.Receive.Execute("MYSERVER");
			Console.ReadLine();
		}
	}
}
