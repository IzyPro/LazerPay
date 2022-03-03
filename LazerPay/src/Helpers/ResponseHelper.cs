using LazerPayNET.Exceptions;
using LazerPayNET.Models.Responses;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Helpers
{
    public static class ResponseHelper
    {
		public static string ProcessResponse(IRestResponse response)
		{
			int statusCode = (int)response.StatusCode;
			ErrorResponse error = new ErrorResponse();
			MultiErrorResponse multiError = new MultiErrorResponse();
			switch (statusCode)
			{
				case 200:
				case 201:
					return response.Content;
				case 401:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new UnAuthorizedException(error.Message);
				case 403:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ForbiddenException(error.Message);
				case 404:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new InvalidResourceException(error.Message);
				case 406:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new NotAcceptableException(error.Message);
				case 422:
					multiError = JsonConvert.DeserializeObject<MultiErrorResponse>(response.Content);
					foreach (var newError in multiError.Errors)
					{
						throw new InvalidPayloadException(newError.ToString());
					}
					return null;
				case 503:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ServerUnavailableException(error.Message);
				default:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ServerErrorException(error.Message);
			}
		}
    }
}
