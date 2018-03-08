using System;

namespace Send
{
	class Program
    {
        static void Main(string[] args)
        {
			var name =  Console.ReadLine();
			Core.Send.Execute("MYSERVER", name);
		}
	}
}
