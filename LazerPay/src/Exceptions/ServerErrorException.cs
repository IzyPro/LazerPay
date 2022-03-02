using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
{
    public class ServerErrorException : Exception
	{
		public ServerErrorException()
		{

		}

		public ServerErrorException(string message) : base(String.Format("Server Error: {0}", message))
		{

		}
	}
}
