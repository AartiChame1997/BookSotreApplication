using controllermodelviewDemo.Data;
using controllermodelviewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Repository
{
    public class BookRepository
    {
   


        private readonly BookDbContext _context=null;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var New_data = new Book()
            {
                Title= model.Title,
                Author= model.Author,
                Description=model.Description,
                Category=model.Category

            };
            await _context.Books.AddAsync(New_data);
           await _context.SaveChangesAsync();

            return New_data.id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {

            var books = new List<BookModel>();
            var Result =_context.Books.ToList();

            if(Result?.Any()==true)
            {
                foreach(var b in Result)
                {
                    books.Add(new BookModel()
                    {

                        Author=b.Author,
                        Title=b.Title,
                        Category=b.Category,
                        Description=b.Description,
                        

                    });

                       

                }
            }
            return books;
                
        }
        public BookModel GetBookById(int id)
        {
            return data.Where(x => x.id == id).FirstOrDefault();

            //var book =  _context.Books.Where(m => m.id == id).ToList();
            //return book;

        }

        public List<BookModel> Datasource()
        {
            return new List<BookModel>
            { new BookModel(){id=1,Title="C",Author="abc"},
              new BookModel(){id=2,Title="C++",Author="pqr"}



            };
        }

        List<BookModel> data = new List<BookModel>()
        { 
            new BookModel() { id=1,Title="MVC",Author="abc",Description="This is complete guide of mvc",},

            new BookModel() {id=2,Title="Asp.net",Author="xyz",Description="This is complete guide of Asp.net"},

             new BookModel() {id=3,Title="C-Sharp",Author="xuv",Description="This is complete guide of C-Sharp"}
        };
    }
}
