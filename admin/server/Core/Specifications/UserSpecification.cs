using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
	public class UserSpecification : BaseSpecification<User>
	{
		public UserSpecification(UserSpecParams userParams)
		{
			AddInclude(x => x.Learner);
			ApplyPaging(userParams.PageSize * (userParams.pageIndex - 1), userParams.PageSize);
		}
		

		public UserSpecification(string sort)
		{
			AddInclude(x => x.Learner);
			AddOrderBy(x => x.IdUser);
		}
		
		public UserSpecification(long IdUser) : base(x => x.IdUser == IdUser)
		{
			AddInclude(x => x.Learner);
		}
		
	}
}