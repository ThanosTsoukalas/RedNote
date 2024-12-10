using Windows.ApplicationModel;

namespace RedNote
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await StartupBtn.FadeTo(0, 100, Easing.BounceOut);
            System.Threading.Thread.Sleep(100);
            StartupBtn.IsVisible = false;
            SplashFirstLabel.IsVisible = true;
            await SplashFirstLabel.FadeTo(1, 1000, Easing.BounceIn);

            System.Threading.Thread.Sleep(100);
            SplashFirstLabel.Text = "Getting everything ready.";
            System.Threading.Thread.Sleep(100);
            SplashFirstLabel.Text = "Getting everything ready..";
            System.Threading.Thread.Sleep(100);
            SplashFirstLabel.Text = "Getting everything ready...";
            System.Threading.Thread.Sleep(100);

            await SplashFirstLabel.FadeTo(0, 1000, Easing.BounceOut);

            System.Threading.Thread.Sleep(100);
            SplashFirstLabel.IsVisible = false;




        }
    }

}
