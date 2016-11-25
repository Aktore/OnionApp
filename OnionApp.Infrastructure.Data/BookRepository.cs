using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using OnionApp.Domain.Interfaces;
using OnionApp.Domain.Core;


namespace OnionApp.Infrastructure.Data
{
    class BookRepository : IBookRepository
    {
        private OrderContext db;

        public BookRepository()
        {
            this.db = new OrderContext();
        }
        public IEnumerable<Book> GetBookList()
        {
            return db.Books.ToList();
        }
        public void Create(Book book)
        {
            db.Books.Add(book);
        }

        public void Delete(int Id)
        {
            Book book = db.Books.Find(Id);
            if (book != null)
                db.Books.Remove(book);
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Book GetBook(int Id)
        {
            return db.Books.Find(Id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }
    }
}
