namespace SmartPlantCare;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnRegister_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("register");
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("home");
    }

	private void btnForgotPassword_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("forgot");
    }
}

