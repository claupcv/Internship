using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;

namespace DataAccess
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected readonly DbContext Context;

		public void Create(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> GetAll()
		{
			return Context.Set<T>().ToList();
		}

		public T GetByID(int ID)
		{
			throw new NotImplementedException();
		}

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}

