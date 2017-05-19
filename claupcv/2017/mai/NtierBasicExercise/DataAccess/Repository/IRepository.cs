using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess
{
    public interface IRepository<T> where T : class
    {
		T GetByID(int ID);
		void Create(T entity);
		void Update(T entity);
		void Delete(T entity);
		IEnumerable<T> GetAll();
		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);



	}
}
