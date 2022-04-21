using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBookService
    {
        Task<List<BookListDTO>> GetAllAsync();
        Task CreateAsync(BookListDTO bookList);
    }
}
