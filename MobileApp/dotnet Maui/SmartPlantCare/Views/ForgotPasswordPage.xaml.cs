namespace SmartPlantCare.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}

	private void btnGetNewPassword_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("login");
    }

	private void btnRegister_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("register");
    }
}