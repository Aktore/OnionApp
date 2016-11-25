﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface IBookRepository: IDisposable
    {
        IEnumerable<Book> GetBookList();
        Book GetBook(int Id);
        void Create(Book item);
        void Update(Book item);
        void Delete(int Id);
        void Save();
    }
}
