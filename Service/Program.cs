using System;
using System.ServiceProcess;

namespace Service
{
	static class Program
	{
		static void Main()
		{
			var service = new Service();
			if (Environment.UserInteractive)
			{
				service.InteractiveStart();
				Console.WriteLine("service running.  Press enter to exit");
				Console.ReadLine();
				service.InteractiveStop();
				return;
			}
			ServiceBase.Run(service);
		}
	}
}
