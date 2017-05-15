using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    interface IEntityBase
    {
		T GetById(int id);
		IEnumerable<T> List();
		IEnumerable<T> List(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
	}
}
