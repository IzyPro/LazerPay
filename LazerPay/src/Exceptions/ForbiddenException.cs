using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
{
    public class ForbiddenException : Exception
    {
		public ForbiddenException()
		{

		}

		public ForbiddenException(string message) : base(String.Format("Access Denied: {0}", message))
		{

		}
    }
}
