namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOrderClicked(object? sender, EventArgs e)
        {
            string produkt = ProductEntry.Text;
            string ilosc = QuantityEntry.Text;
            string adres = DeliveryAddressEntry.Text;

            DisplayAlert("Zapisano", $"Produkt: {produkt}, ilość: {ilosc}, adres: {adres}", "OK");
        }
    }
}
