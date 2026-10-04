namespace _04_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSignUpClicked(object? sender, EventArgs e)
        {
            string imie = NameEntry.Text;
            string nazwisko = LastNameEntry.Text;
            bool czyZaakceptowano = AcceptCheckbox.IsChecked;
            bool czyCertyfikat = ToggleCartificate.IsToggled;

            etykietaPodsumowanie.Text =
                $"Imię: {imie}\n" +
                $"Nazwisko: {nazwisko}\n" +
                $"Posiadam podstawową wiedzę: {(czyZaakceptowano ? "Tak" : "Nie")}\n" +
                $"Chcę otrzymać certyfikat: {(czyCertyfikat ? "Tak" : "Nie")}\n";
        }
    }
}
