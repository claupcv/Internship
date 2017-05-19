using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess
{
	public class XMLRepository<T> : IRepository<T> where T : class
	{

		protected readonly XmlDocument Context;

		readonly XMLContext _xmlContext;

		IList<T> _entities;

		public IQueryable<T> Entities
		{
			get
			{
				return XmlEntities.AsQueryable();
			}
		}

		protected IList<T> XmlEntities
		{
			get
			{
				return _entities ?? (_entities = _xmlContext.Set<T>());
			}
		}

		public XMLRepository(XmlDocument context)
		{
			Context = context;
		}

		public void Create(T entity)
		{
			if (entity.ID == default(int)) //only add if id = default(int)
			{
				var lastEntity = Entities.LastOrDefault();
				if (lastEntity != null)
					entity.Id = lastEntity.Id + 1;
				else
					entity.Id = 1;

				XmlEntities.Add(item);
				_xmlContext.SaveChanges(XmlEntities);
			}
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
			throw new NotImplementedException();
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
