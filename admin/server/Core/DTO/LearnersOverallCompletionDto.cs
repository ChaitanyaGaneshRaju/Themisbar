using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Core.DTO
{
	public class LearnersOverallCompletionDto
	{
		public string Name {get; set;}
		
		public string Email {get; set;}
		public string Course {get; set;}
		public string OverallCompletion {get; set;}
	}
}