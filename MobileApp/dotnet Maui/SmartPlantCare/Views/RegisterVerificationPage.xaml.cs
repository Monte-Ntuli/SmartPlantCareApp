namespace SmartPlantCare.Views;

public partial class RegisterVerificationPage : ContentPage
{
	public RegisterVerificationPage()
	{
		InitializeComponent();
	}

	private void btnCheckEmail_Clicked(object sender, EventArgs e)
	{
        //Shell.Current.GoToAsync("register");
    }

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("login");
    }
}