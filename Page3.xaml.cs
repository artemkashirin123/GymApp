namespace GymApp;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void Button1_Clicked(object sender, EventArgs e)
    {
        Page4 page = new Page4();
        Navigation.PushAsync(page);
    }
}