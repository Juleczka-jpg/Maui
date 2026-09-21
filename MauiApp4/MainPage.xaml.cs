namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowButtonClicked(object? sender, EventArgs e)
        {
            string miasto = MiastoEntry.Text;
            string imie = ImieEntry.Text;

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(miasto))
            {
                ResultLabel.Text = "Uzupełnij oba pola";
            }
            else
            {
                ResultLabel.Text = $"Witaj, {imie} z miasta {miasto}";
            }
    }   }
}
