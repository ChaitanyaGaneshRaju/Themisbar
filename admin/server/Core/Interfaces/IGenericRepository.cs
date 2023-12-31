using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Specifications;

namespace Core.Interfaces
{
	public interface IGenericRepository<T>
	{
		Task<T> GetByIdAsync(long id);
		Task<IReadOnlyList<T>> ListAllAsync();

		Task<T> GetEntityWithSpec(ISpecification<T> spec);
		Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
		
		Task<int> CountAsync(ISpecification<T> spec);
	}
}