using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using AutoMapper;
using Core.DTO;
using Infrastructure.Data;

namespace API.DAO
{
	public class IndividualViewDao
	{
		private readonly DataContext _context;
		private readonly Mapper _mapper;
		
		public IndividualViewDao()
		{
			this._context = new DataContext();
			this._mapper = MapperConfig.InitializeAutomapper();
		}
		
		// public List<LearnersOverallCompletionDto> GetListOfLearners(long facultyId, long IdCourse)
		// {
		// 	List<LearnersOverallCompletionDto> learnersList = (from ) 
		// }
		
	}
}