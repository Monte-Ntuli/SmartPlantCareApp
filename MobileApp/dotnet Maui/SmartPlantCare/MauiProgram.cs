using SmartPlantCare.ViewModel;
using SmartPlantCare.Views;

namespace SmartPlantCare;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		Routing.RegisterRoute("register", typeof(RegisterPage));
		Routing.RegisterRoute("login", typeof(MainPage));
        Routing.RegisterRoute("registerVerification", typeof(RegisterVerificationPage));
        Routing.RegisterRoute("forgot", typeof(ForgotPasswordPage));
		Routing.RegisterRoute("home", typeof(HomePlantPage));

        return builder.Build();
	}
}
