namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            PowitanieLabel.Text = "Dziękujemy za uruchomienie aplikacji";
        }
    }
}
