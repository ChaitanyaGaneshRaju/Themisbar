using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
	public class APIResponse
	{
		
		public int statusCode { get; set; }
		public string Message { get; set; }
		
		public APIResponse(int statusCode, string message=null)
		{
			this.statusCode = statusCode;
			Message = message ?? GetDefaultMessageForStatusCode(statusCode);
		}

		private string GetDefaultMessageForStatusCode(int statusCode)
		{
			return statusCode switch
			{
				400 => "A bad request, you have made",
				401 => "Authorized, you are not",
				404 => "Resource found, it was not",
				500 => "Error are the path to the dark side. Errors Lead to anger. Anger leads to hate. Hate leads to career change.",
				_ => null
			};
		}
	}
}