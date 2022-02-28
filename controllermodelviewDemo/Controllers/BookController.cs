using controllermodelviewDemo.Models;
using controllermodelviewDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Controllers
{
    public class BookController : Controller
    {

        [ViewData]
        public string Title { get; set; }
        private readonly BookRepository _bookrepo = null;

        public BookController(BookRepository bookRepository)
        {
            _bookrepo = bookRepository;
        }
        public async Task<ActionResult> GetallBooks()
        {
            Title = "GetAllBook";
            var data= await _bookrepo.GetAllBooks();
            return View(data);
        }
        public ActionResult GetBook(int id)
        {
            Title = "GetBookById";

            var Getbookbyid= _bookrepo.GetBookById(id);

            return View(Getbookbyid);
        }

    
       
        
    }
}
