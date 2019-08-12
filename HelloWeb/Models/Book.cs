
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HelloWeb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string String { get; set; }
        public string Description { get; set; }
        public string ImageUrl  { get; set; }
        public virtual  Author Author { get; set; }
    }
}
