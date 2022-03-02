using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
{
    public class UnAuthorizedException : Exception
    {
		public UnAuthorizedException()
		{

		}

		public UnAuthorizedException(string message) : base(String.Format("Unauthorized: {0}", message))
		{

		}
	}
}
