﻿using LibraryManagmentSystem.Models;

namespace LibraryManagmentSystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        LibraryContext context;
        public BookRepository(LibraryContext _context) 
        {
            context = _context;
        }
        public bool Add(Book book)
        {
            try
            {
                context.Books.Add(book);
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Book book)
        {
            try
            {
                context.Books.Remove(book);
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.FirstOrDefault(B => B.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public bool Update(Book book)
        {
            try
            {
                context.Update(book);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}