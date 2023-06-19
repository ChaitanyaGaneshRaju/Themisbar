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
		public UserSpecification(long id) : base(x => x.IdUser == id)
		{
			AddInclude(x => x.Learner);
		}

		public UserSpecification(string sort)
		{
			AddInclude(x => x.Learner);
			AddOrderBy(x => x.IdUser);
		}
		
	}
}