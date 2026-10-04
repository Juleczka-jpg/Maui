namespace _08_03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculateClicked(object? sender, EventArgs e)
        {
            if (!double.TryParse(HeighthEntry.Text, out double height))
            {
                await DisplayAlert("Błąd", "Wysokość musi być liczbą", "OK");
                return;
            }

            if (!double.TryParse(WidthEntry.Text, out double width))
            {
                await DisplayAlert("Błąd", "Szerokość musi być liczbą", "OK");
                return; 
            }

            if (height <= 0 || width <= 0)
            {
                await DisplayAlert("Błąd", "Wymiary muszą być liczbami dodatnimi", "OK");
                return;
            }

            double area = height * width;
            AreaLabel.Text = $"Pole powierzchni: {area}";

        }

        private async void OnDeleteClicked(object? sender, EventArgs e)
        {
            bool potwierdzenie = await DisplayAlertAsync("Wynik", "Czy na pewno chcesz usunąć dane?", "Tak", "Nie");

            if(potwierdzenie)
            {
                HeighthEntry.Text = string.Empty;
                WidthEntry.Text = string.Empty;
                AreaLabel.Text = string.Empty;
            }
            else
            {
                return;
            }
        }
    }
}
