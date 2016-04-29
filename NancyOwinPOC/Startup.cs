using System;
using Owin;

namespace NancyOwinPOC
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseNancy();
		}
	}
}

