using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Exceptions
{
    public class InvalidPayloadException : Exception
	{
		public InvalidPayloadException()
		{

		}

		public InvalidPayloadException(string message) : base(String.Format("Invalid Payload: {0}", message))
		{

		}
	}
}
