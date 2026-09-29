namespace MauiApp15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object? sender, EventArgs e)
        {
            string tekst = AgeEntry.Text;
            bool sukces = int.TryParse(tekst, out int wiek);

            if (sukces == true)
            {
                if (wiek < 1 || wiek > 120)
                {
                    DisplayAlert("Wiek", $"Wiek musi być z zakresu 1–120", "OK");

                }
                else
                {
                    ResultLabel.Text = $"Twój wiek to: {wiek}";
                }
            }
            else
            {
                DisplayAlert("Błąd", "Proszę wprowadzić poprawny wiek.", "OK");
            }
        }
    }
}
