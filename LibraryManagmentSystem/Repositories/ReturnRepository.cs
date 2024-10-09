﻿using LibraryManagmentSystem.Models;

namespace LibraryManagmentSystem.Repositories
{
    public class ReturnRepository : IReturnRepository
    {
        LibraryContext context;
        public ReturnRepository(LibraryContext _context)
        {
            context = _context;
        }
        public bool Add(Return Return)
        {
            try
            {
                context.Returns.Add(Return);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Return Return)
        {
            try
            {
                context.Returns.Remove(Return);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Return> GetAll()
        {
            return context.Returns.ToList();
        }

        public Return GetById(int id)
        {
            return context.Returns.FirstOrDefault(C => C.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public bool Update(Return Return)
        {
            try
            {
                context.Returns.Update(Return);
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
