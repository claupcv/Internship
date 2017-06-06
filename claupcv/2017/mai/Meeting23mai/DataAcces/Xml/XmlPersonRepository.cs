﻿using DataAccess.Abstractions;
using  Core;
using  Core.Extensions;
using  Core.IO;
using  Core.Paging;
using  Core.Sorting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataAccess.Xml
{
  public class XmlPersonRepository : IPersonRepository
  {
    private readonly XDocument xmlDocument;

    public XmlPersonRepository(GlobalSettings settings, IPathServices pathServices = null)
      : this(xmlPath: settings?.RepositoriesConfig?.Xml?.Path, pathServices: pathServices)
    {

    }

    public XmlPersonRepository(string xmlPath, IPathServices pathServices = null)
    {
      if (string.IsNullOrWhiteSpace(xmlPath))
      {
        throw new ArgumentNullException($"{nameof(xmlPath)}");
      }

      if (pathServices != null)
      {
        xmlPath = xmlPath.Replace(PathPlaceholders.CurrentDirectory, pathServices.GetCurrentDirectory());
      }

      if (!File.Exists(xmlPath))
      {
        throw new FileNotFoundException($"XML file cannot be found at path '{xmlPath}'");
      }

      this.xmlDocument = XDocument.Load(xmlPath);
    }

    public SortedPagedCollection<Person, PersonSortCriteria> GetPersonsPaged(int pageIndex, int pageSize, PersonSortCriteria sortCriteria, SortDirection sortDirection)
    {
      IEnumerable<Person> query = from persElement in this.xmlDocument.Descendants("Person")
                                  let dateOfBirthString = persElement.Element("DateOfBirth")?.Value
                                  let dateOfBirthFormat = persElement.Element("DateOfBirth") != null ?
                                                            persElement.Element("DateOfBirth").Attribute("format")?.Value
                                                            :
                                                            ""
                                  select new Person()
                                  {
                                    Id = int.Parse(persElement.Attribute("id").Value),
                                    FirstName = persElement.Element("FirstName")?.Value,
                                    LastName = persElement.Element("LastName")?.Value,
                                    DateOfBirth = dateOfBirthString.ParseWithFormat(dateOfBirthFormat)
                                  };

      switch (sortCriteria)
      {
        case PersonSortCriteria.ById:
        default:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.Id);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.Id);
              break;
          }
          break;

        case PersonSortCriteria.ByFirstName:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.FirstName);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.FirstName);
              break;
          }
          break;

        case PersonSortCriteria.ByLastName:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.LastName);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.LastName);
              break;
          }
          break;

        case PersonSortCriteria.ByBirthDate:
          switch (sortDirection)
          {
            case SortDirection.Ascending:
            default:
              query = query.OrderBy(p => p.DateOfBirth);
              break;

            case SortDirection.Descending:
              query = query.OrderByDescending(p => p.DateOfBirth);
              break;
          }
          break;
      }

      int totalRecordsCount = query.Count();

      var data = query.Skip(pageIndex * pageSize).Take(pageSize);

      return new SortedPagedCollection<Person, PersonSortCriteria>(data, pageIndex, pageSize, totalRecordsCount, sortCriteria, sortDirection);
    }
  }
}
