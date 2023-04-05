namespace GymApp;

public partial class Page3M : ContentPage
{
	public Page3M()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Page4 page = new Page4();
        Navigation.PushAsync(page);
    }
}