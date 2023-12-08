using Library_MAUI_R53.Models;
using Library_MAUI_R53.Services;
using Library_MAUI_R53.Services.Interfaces;
using Library_MAUI_R53.ViewModels;
using Library_MAUI_R53.Views;
using Library_MAUI_R53.Views.Desktop;
using Syncfusion.Maui.Core.Hosting;

namespace Library_MAUI_R53;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddHttpClient<IGenericService<Publisher>, PublsiherService>();
		builder.Services.AddSingleton<PublisherViewModel>();
		builder.Services.AddSingleton<PublisherViewPage>();
		
		builder.Services.AddHttpClient<IGenericService<Book>, BookService>();
		builder.Services.AddSingleton<BookViewModel>();
		builder.Services.AddSingleton<BookViewPage>();


		return builder.Build();
	}
}
