namespace GymApp;

public partial class Page4 : ContentPage
{
    int Mode = 0;
	public Page4()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
        btn1.BackgroundColor = Color.FromArgb("#e3dfbc");
        btn2.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn3.BackgroundColor = Color.FromArgb("#FFFFFF");
        Mode = 1;
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        btn1.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn2.BackgroundColor = Color.FromArgb("#e3dfbc");
        btn3.BackgroundColor = Color.FromArgb("#FFFFFF");
        Mode = 2;
    }

    private void btn3_Clicked(object sender, EventArgs e)
    {
        btn1.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn2.BackgroundColor = Color.FromArgb("#FFFFFF");
        btn3.BackgroundColor = Color.FromArgb("#e3dfbc");
        Mode = 3;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Mode == 0) DisplayAlert("Alert", "Choose your gender", "OK");
        if (Mode == 1) Navigation.PushAsync(new Page5());
        if (Mode == 2) Navigation.PushAsync(new Page5());
        if (Mode == 3) Navigation.PushAsync(new Page5());
    }
}