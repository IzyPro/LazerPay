﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Models.Responses
{
    public class MultiErrorResponse
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("errors")]
		public dynamic Errors { get; set; }
	}
}
