namespace MauiApp10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRoomChanged(object? sender, EventArgs e)
        {
            string sala = RoomPicker.SelectedItem?.ToString();

            if (sala != null)
            {
                UpdateSummary();
            }
        }

        private void OnQuantityChanged(object sender, ValueChangedEventArgs e)
        {
            int ilosc = (int)QuantityStepper.Value;
            QuantityLabel.Text = $"Liczba osób: {ilosc}";
            UpdateSummary();
        }

        private void OnDataChanged(object sender, DateChangedEventArgs e)
        {
            UpdateSummary();
        }

        private void OnRegisterClicked(object? sender, EventArgs e)
        {
            if (RoomPicker.SelectedItem == null)
            {
                ResultLabel.Text = "Wybierz salę";
                ResultLabel.IsVisible = true;
            }
            else
            {
                UpdateSummary();
                ResultLabel.IsVisible = true;
            }
        }

        private void UpdateSummary()
        {
            string sala = RoomPicker.SelectedItem?.ToString();
            int ilosc = (int)QuantityStepper.Value;
            DateTime data = ReservationDatePicker.Date ?? DateTime.Now;

            ResultLabel.Text = $"Rezerwacja:\n" +
                              $"- Sala: {sala}\n" +
                              $"- Liczba osób: {ilosc}\n" +
                              $"- Data: {data:dd.MM.yyyy}";
        }
    }
}
