﻿using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Customer;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepositry _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepositry bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookListDTO>> GetAllAsync()
        {
            var model = await _bookRepository.GetAllAsync();

            return _mapper.Map<List<BookListDTO>>(model);
        }
    }
}
