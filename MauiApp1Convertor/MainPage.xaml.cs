namespace MauiApp1Convertor;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	

    private void btnSubmit_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("OK", "Number is Valid", "OK");
    }
}

