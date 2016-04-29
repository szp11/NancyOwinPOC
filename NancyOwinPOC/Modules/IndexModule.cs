using System;
using Nancy;

namespace NancyOwinPOC
{
	public class IndexModule : NancyModule
	{
		public IndexModule ()
		{
			Get [""] = _ => "WololoooOoOOooOoOOo!!! HayoOoOoo! (From the Windows (Nancy) Playground)";
		}
	}
}

