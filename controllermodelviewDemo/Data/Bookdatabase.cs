using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Data
{
    public class Bookdatabase
    {
       
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }
            public string Authers { get; set; }
            public string publishYear { get; set; }
            //public decimal BasePrice { get; set; }
        
    }
}
