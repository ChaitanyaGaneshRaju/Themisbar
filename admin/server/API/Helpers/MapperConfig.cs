using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities;

namespace API.Helpers
{
	public class MapperConfig
	{
		public static Mapper InitializeAutomapper()
		{
			//Provide all the Mapping Configuration
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<FacultyCourse, FacultyCoursesDto>();
				
				cfg.CreateMap<FacultyLawSchool, FacultyLawSchoolsDto>()
					  .ForMember(fls => fls.Name, opt => opt.MapFrom(ls => ls.LawSchool.Name));
				
			});

			var mapper = new Mapper(config);
			return mapper;
		}
	}
}