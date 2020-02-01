using System;
using System.Collections.Generic;
using BooksApi.Models;  

namespace BooksApi.Models
{
  public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
  {
    string BooksCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}