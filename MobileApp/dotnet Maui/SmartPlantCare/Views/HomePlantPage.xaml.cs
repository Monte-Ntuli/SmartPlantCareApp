namespace SmartPlantCare.Views;

public partial class HomePlantPage : ContentPage
{
	public HomePlantPage()
	{
		InitializeComponent();
	}

	private void btnAddPlant_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("addPlant");
    }
}