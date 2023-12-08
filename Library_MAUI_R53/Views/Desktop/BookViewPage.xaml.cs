using Library_MAUI_R53.ViewModels;

namespace Library_MAUI_R53.Views.Desktop;

public partial class BookViewPage : ContentPage
{
	public BookViewPage(BookViewModel bm)
	{
		InitializeComponent();
		BindingContext = bm;
	}
}