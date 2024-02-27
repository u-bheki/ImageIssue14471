namespace ImageIssue14471;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//page-2");
    }
}