﻿using Models;
using Models.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public interface IPersonRepository
	{
		SortedCollection<Person, PersonSortCriteria> GetPersonSorted(PersonSortCriteria sortCriteria, SortDirection sortDirection);
	}
}
