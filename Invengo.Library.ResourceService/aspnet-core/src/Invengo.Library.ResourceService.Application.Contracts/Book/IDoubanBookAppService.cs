using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.ResourceService
{
    public interface IDoubanBookAppService :
        ICrudAppService< //Defines CRUD methods
            DoubanBookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CreateUpdateDoubanBookDto, //Used to create a new book
            CreateUpdateDoubanBookDto> //Used to update a book
    {

    }
}
