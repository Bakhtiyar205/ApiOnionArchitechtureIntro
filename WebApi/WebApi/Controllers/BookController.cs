using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Book;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _bookService.GetAllAsync());
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create([FromBody]BookListDTO bookList)
        {
            await _bookService.CreateAsync(bookList);
        }
    }
}
