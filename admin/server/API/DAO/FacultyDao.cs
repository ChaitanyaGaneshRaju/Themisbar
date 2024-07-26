using API.Helpers;
using AutoMapper;
using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.DAO
{
	public class FacultyDao
	{
		private readonly DataContext _context;
		private readonly GenericRepository<FacultyLawSchool> _facultyLawSchoolRepo;
		private readonly Mapper _mapper;

		public FacultyDao()
		{
			this._context = new DataContext();
			this._facultyLawSchoolRepo = new GenericRepository<FacultyLawSchool>(_context);
			this._mapper = MapperConfig.InitializeAutomapper();
		}

		public List<FacultyCoursesDto> GetFacultyCourses(long facultyId)
		{
			List<FacultyCoursesDto> facultyCourses = (from fc in _context.FacultyCourses
			join c in _context.Courses on fc.IdCourse equals c.IdCourse
			where fc.IdUser == facultyId
			select new FacultyCoursesDto
			{
				IdUser = fc.IdUser,
				IdCourse = c.IdCourse,
				Name = c.Name
			}).ToList();

			return facultyCourses;
		}
		
		public List<FacultyCoursesDto> GetFacultyManagedCourses(long facultyId)
		{
			List<FacultyCoursesDto> facultyManagedCourses = (from fmc in _context.FacultyManagedCourses
			join c in _context.Courses on fmc.IdCourse equals c.IdCourse
			where fmc.IdUser == facultyId
			select new FacultyCoursesDto
			{
				IdUser = fmc.IdUser,
				IdCourse = c.IdCourse,
				Name = c.Name
			}).ToList();

			return facultyManagedCourses;
		}
		
		public FacultyUserDetails GetFacultyUserDetails(long facultyId)
		{
			FacultyUserDetails FacultyUserDetails = (from f in _context.Faculties
			join u in _context.Users on f.IdUser equals u.IdUser
			where f.IdUser == facultyId
			select new FacultyUserDetails
			{
				IdUser = f.IdUser,
				LastName = u.LastName,
				FirstName = u.FirstName,
				Email = u.Email,
				HomePhone = u.HomePhone 
			}).FirstOrDefault();

			return FacultyUserDetails;
		}
		
		public  IReadOnlyList<FacultyLawSchoolsDto> GetFacultyLawSchools(long IdUser)
		{
			var facultyLawSchoolsSpec = new FacultyLawSchoolsSpecification(IdUser);
			IReadOnlyList<FacultyLawSchool> facultyLawSchools = _facultyLawSchoolRepo.ListAsync(facultyLawSchoolsSpec).Result;
			return _mapper.Map<List<FacultyLawSchoolsDto>>(facultyLawSchools);
			// return facultyLawSchools;
		}
		
		
		

	}
}