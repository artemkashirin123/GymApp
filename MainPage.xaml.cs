namespace GymApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Page2 page = new Page2();
        Navigation.PushAsync(page);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Page2 page = new Page2();
        Navigation.PushAsync(page);
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Page2 page = new Page2();
        Navigation.PushAsync(page);
    }
}

