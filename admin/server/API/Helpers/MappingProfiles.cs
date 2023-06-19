using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities;

namespace API.Helpers
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<User, UserLearnerDto>();
		}
	}
}