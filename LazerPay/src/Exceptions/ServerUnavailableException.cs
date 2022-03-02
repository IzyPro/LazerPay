using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
{
    public class ServerUnavailableException : Exception
	{
		public ServerUnavailableException()
		{

		}

		public ServerUnavailableException(string message) : base(String.Format("Server Unavailable: {0}", message))
		{

		}
	}
}
