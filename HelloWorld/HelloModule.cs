using System;
using Nancy;

namespace HelloWorld
{
	public class HelloModule : NancyModule
	{
		public HelloModule ()
		{
			Get["/"] = parameters => "Hello World";
		}
	}
}

