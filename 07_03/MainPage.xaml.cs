using Microsoft.Maui.Graphics.Text;
using Microsoft.Maui.Graphics;

namespace _07_03
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderChanged(object? sender, ValueChangedEventArgs e)
        {
            int r = (int)RedSlider.Value;
            int g = (int)GreenSlider.Value;
            int b = (int)BlueSlider.Value;
            Color kolor = Color.FromRgb(r, g, b);
            this.BackgroundColor = kolor;

            int srednia = (r + g + b) / 3;

            if (srednia < 128)
            {
                ColorLabel.TextColor = Colors.White;
            }
            else
            {
                ColorLabel.TextColor = Colors.Black;
            }

            ColorLabel.Text = $"Aktualny kolor: {kolor.ToHex()}";
        }
    }
}
