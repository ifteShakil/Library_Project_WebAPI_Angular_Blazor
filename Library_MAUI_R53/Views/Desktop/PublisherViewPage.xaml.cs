using Library_MAUI_R53.ViewModels;

namespace Library_MAUI_R53.Views;

public partial class PublisherViewPage : ContentPage
{
	public PublisherViewPage(PublisherViewModel pm)
	{
		InitializeComponent();
		BindingContext = pm;
	}
}