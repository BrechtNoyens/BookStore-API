﻿using AutoMapper;
using BookStore_API.Data;
using BookStore_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookStore_API.DTOs.AuthorDTO;
using static BookStore_API.DTOs.BookDTO;

namespace BookStore_API.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Author, AuthorCreateDTO>().ReverseMap();
            CreateMap<Author, AuthorUpdateDTO>().ReverseMap();
          
            CreateMap<Book, BookCreateDTO>().ReverseMap();
            CreateMap<Book, BookUpdateDTO>().ReverseMap();
        }
        
    }
}
