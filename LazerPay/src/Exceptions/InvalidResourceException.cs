﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Exceptions
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
