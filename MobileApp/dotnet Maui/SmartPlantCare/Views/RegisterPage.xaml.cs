namespace SmartPlantCare.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("login");
    }

	private void btnRegister_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("registerVerification");
    }
}