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
    public partial class PublisherViewModel:BaseViewModel
    {
        private readonly IGenericService<Publisher> pubS;

        public ObservableRangeCollection<Publisher> Publishers { get; set; } = new();

        public PublisherViewModel(IGenericService<Publisher> genericP)
        {
            pubS = genericP;
            Title = "Publisher";
            GetPublisher();
        }

        private async void GetPublisher()
        {
            var p = await pubS.GetAll();
            if (p is null)
            {
                return;
            }
            //p.Clear();

            foreach (var item in p)
            {
                Publishers.Add(item);
            }
        }
    }
}
