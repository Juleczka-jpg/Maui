namespace _04_03
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
            string forma;
            bool czyZaakceptowano = AcceptCheckbox.IsChecked;
            bool czyCertyfikat = ToggleCartificate.IsToggled;
            string oczekiwania = ExpectationsEditor.Text;

            if (opcjaStacjonarny.IsChecked)
            {
                forma = "Stacjonarny";
            }
            else if (opcjaOnline.IsChecked)
            {
                forma = "Online";
            }
            else
            {
                forma = "Hybrydowy";
            }

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                etykietaPodsumowanie.Text = "Podaj imię i naziwsko.";
            }
            else
            {
                etykietaPodsumowanie.Text =
                    $"Imię: {imie}\n" +
                    $"Nazwisko: {nazwisko}\n" +
                    $"Forma kursu: {forma}\n" +
                    $"Posiadam podstawową wiedzę: {(czyZaakceptowano ? "Tak" : "Nie")}\n" +
                    $"Chcę otrzymać certyfikat: {(czyCertyfikat ? "Tak" : "Nie")}\n" +
                    $"Wpisane oczekiwania: {oczekiwania}\n";
            }
        }
    }
}
