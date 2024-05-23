using Microsoft.Maui.Controls;

namespace TallerP2;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
        InitializeComponent();

    }
    private async void OnImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
  
}