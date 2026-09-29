namespace MauiApp11
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int wartosc = (int)e.NewValue;

            ValueLabel.Text = "Wartość: " + wartosc;
            ResultLabel.Text = (wartosc < 128) ? "Mało" : "Dużo";
        }
    }
}
