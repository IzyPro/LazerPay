using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
{
    public class NotAcceptableException : Exception
	{
		public NotAcceptableException()
		{

		}

		public NotAcceptableException(string message) : base(String.Format("Invalid/Unacceptable Protocol: {0}", message))
		{

		}
	}
}
