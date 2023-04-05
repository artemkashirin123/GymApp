namespace GymApp;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Text1.Text == null || Text2.Text == null) DisplayAlert("Alert", "Enter your height and weight", "OK");
        else Navigation.PushAsync(new Page6());
    }
}