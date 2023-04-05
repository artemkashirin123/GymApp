namespace GymApp;

public partial class Page2 : ContentPage
{
    int Mode = 0;
	public Page2()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
        btn2.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn1.BackgroundColor = Color.FromArgb("#e3dfbc");
        Mode = 1;
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        btn1.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn2.BackgroundColor = Color.FromArgb("#e3dfbc");
        Mode = 2;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Mode == 0) DisplayAlert("Alert", "Choose your gender", "OK");
        if (Mode == 1) Navigation.PushAsync(new Page3());
        if (Mode == 2) Navigation.PushAsync(new Page3M());
    }
}