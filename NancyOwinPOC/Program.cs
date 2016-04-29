using System;
using Topshelf;

namespace NancyOwinPOC
{
	class MainClass
	{
		public static void Main()
		{
			HostFactory.Run(x => 
				{
					x.UseLinuxIfAvailable();
					x.Service<NancySelfHost>(s => 
						{
							s.ConstructUsing(name => new NancySelfHost()); 
							s.WhenStarted(tc => tc.Start()); 
							s.WhenStopped(tc => tc.Stop()); 
							s.WhenShutdown(tc => tc.Stop());
						});

					x.RunAsNetworkService();
					x.SetDescription("Nancy Owin/OAuth Self-hosted App"); 
					x.SetDisplayName("Nancy Owin/OAuth Self-hosted Service"); 
					x.SetServiceName("Nancy-Owin-SelfHost"); 
					x.EnableShutdown();
				}); 
		}
	}
}
