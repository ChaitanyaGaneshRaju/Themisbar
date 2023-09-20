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

        public FacultyDao()
		{
			this._context = new DataContext();
            this._facultyLawSchoolRepo = new GenericRepository<FacultyLawSchool>(_context);
        }

		public List<CourseIdNameDto> GetFacultyCourses(long facultyId)
		{
			List<CourseIdNameDto> facultyCourses = (from fc in _context.FacultyCourses
			join c in _context.Courses on fc.IdCourse equals c.IdCourse
			where fc.IdUser == facultyId
			select new CourseIdNameDto
			{
				CourseId = c.IdCourse,
				CourseName = c.Name
			}).ToList();

			return facultyCourses;
		}

		public  IReadOnlyList<FacultyLawSchool> GetFacultyLawSchools(long IdUser)
		{
			var facultyLawSchoolsSpec = new FacultyLawSchoolsSpecification(IdUser);
			IReadOnlyList<FacultyLawSchool> facultyLawSchools = _facultyLawSchoolRepo.ListAsync(facultyLawSchoolsSpec).Result;
			return facultyLawSchools;
		}

	}
}