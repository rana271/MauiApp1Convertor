namespace MauiApp1Convertor;

public partial class ValidatePage : ContentPage
{
    Example1ViewModel _context;
    public ValidatePage()
	{
		InitializeComponent();
        _context = new Example1ViewModel();
        BindingContext = _context;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var isValid = _context.Validate();

        if (isValid)
        {
            DisplayAlert(":)", "This form is valid", "OK");
        }
        else
        {
            DisplayAlert(":(", "This form is not valid", "OK");
        }
    }
    private void nameEntry_Unfocused(object sender, FocusEventArgs e)
    {
        _context.Name.Validate();
    }

    private void lastnameEntry_Unfocused(object sender, FocusEventArgs e)
    {
        _context.LastName.Validate();
    }

    private void emailEntry_Unfocused(object sender, FocusEventArgs e)
    {
        _context.Email.Validate();
    }
}