namespace TaskerApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

		private async void SeeMore_Clicked(object sender, EventArgs e)
		{
			
		}

		private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
		{
			await Navigation.PushAsync(new CategoryView());
		}
	}
}
