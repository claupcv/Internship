using  Core;
using  Core.Paging;
using  Core.Sorting;

namespace DataAccess.Abstractions
{
  public interface IPersonRepository
  {
    SortedPagedCollection<Person, PersonSortCriteria> GetPersonsPaged(int pageIndex, int pageSize, PersonSortCriteria sortCriteria, SortDirection sortDirection);
  }
}
