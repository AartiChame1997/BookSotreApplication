using controllermodelviewDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Repository
{
    public interface IBookRepository
    {

        IEnumerable<Bookdatabase> GetAllBooks();
        Bookdatabase GetBookByID(int bookId);
        void InsertBook(Bookdatabase book);
        void DeleteBook(int bookID);
        void UpdateBook(Bookdatabase book);
        void Save();
    }
}
