using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected readonly DbContext Context;

		public Repository(DbContext context)
		{
			Context =context;
		}

		public void Create(T entity)
		{
			Context.Set<T>().Add(entity);
			Context.SaveChanges();
		}

		public void Update(T entity)
		{
			Context.Entry<T>(entity).State = EntityState.Modified;
			Context.SaveChanges();
		}

		public void Delete(T entity)
		{
			Context.Set<T>().Remove(entity);
			Context.SaveChanges();
		}		

		public IEnumerable<T> GetAll()
		{
			return Context.Set<T>().ToList();
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		{
			return Context.Set<T>().Where(predicate);
		}

		public T GetByID(int ID)
		{
			// use FIND above :  public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
			return Context.Set<T>().Find(ID);
		}

		
	}
}

