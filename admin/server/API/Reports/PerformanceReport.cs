using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using AutoMapper;
using Infrastructure.Data;

namespace API.Reports
{
	public class PerformanceReport
	{
		private readonly DataContext _context;
		private readonly Mapper _mapper;


		public PerformanceReport()
		{
			this._context = new DataContext();
			this._mapper = MapperConfig.InitializeAutomapper();
		}

		
	}
}