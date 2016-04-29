using System;
using Microsoft.Owin.Hosting;

namespace NancyOwinPOC
{
	public class NancySelfHost
	{
		private IDisposable m_nancyHost;

		public void Start()
		{
			var url = "http://+:5000";
			m_nancyHost = WebApp.Start<Startup> (url);
		}

		public void Stop()
		{
			m_nancyHost.Dispose ();
			Console.WriteLine("Stopped. Good bye!");
		}
	}
}

