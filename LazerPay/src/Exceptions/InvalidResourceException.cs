using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Exceptions
{
    public class InvalidResourceException : Exception
	{
		public InvalidResourceException()
		{

		}

		public InvalidResourceException(string message) : base(message)
		{

		}
	}
}
