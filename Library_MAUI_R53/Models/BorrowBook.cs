using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library_MAUI_R53.Models
{
    public class BorrowBook
    {
        public int BorrowedBookId { get; set; }
        public string UserId { get; set; }
       
        public int BookId { get; set; }
   
        public int BookCopyId { get; set; }
      
        public DateTime RequestTimestamp { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
     
        public bool IsActive { get; set; }
        public DateTime ActualReturnDate { get; set; }

    }
}
