using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library_MAUI_R53.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Edition { get; set; }
        public int TotalCopies { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public decimal BookPrice { get; set; }
        public string DDCCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDigital { get; set; }
        public bool PublisherAgreement { get; set; }
        public int CategoryId { get; set; }
        public string CoverFileName { get; set; }
        public string EBookFileName { get; set; }
        public string AgreementFileName { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
