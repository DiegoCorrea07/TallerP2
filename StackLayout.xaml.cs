namespace TallerP2;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayout());
    }
}