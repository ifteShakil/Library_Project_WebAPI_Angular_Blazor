using Library_MAUI_R53.Models;
using Library_MAUI_R53.Services.Interfaces;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MAUI_R53.ViewModels
{
    public partial class BookViewModel :BaseViewModel
    {
        private readonly IGenericService<Book> book;

        public ObservableRangeCollection<Book> Books { get; set; } = new();

        public BookViewModel(IGenericService<Book> generic)
        {
            book = generic;
            Title = "Book";
            GetBook();
        }

        private async void GetBook()
        {
            var p = await book.GetAll();
            if (p is null)
            {
                return;
            }
            //p.Clear();

            foreach (var item in p)
            {
                Books.Add(item);
            }
        }
    }
}
