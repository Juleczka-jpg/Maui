namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            PowitanieLabel.Text = "Aplikacja działa poprawnie";
            ZwiekszLicznik();
        }

        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            PowitanieLabel.Text = "Witamy w aplikacji";
            ZwiekszLicznik();
        }

        private void ZwiekszLicznik()
        {
            count++;
            LicznikLabel.Text = $"Kliknięć: {count}";
        }
    }
}
