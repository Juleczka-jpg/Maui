namespace _07_02
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCornsilkClicked(object? sender, EventArgs e)
        {
            Color cornsilk = Color.FromArgb("#FFF8DC");
            this.BackgroundColor = cornsilk;
            ColorLabel.Text = "Aktualny kolor: Cornsilk (#FFF8DC)";
        }
        private void OnPeruClicked(object? sender, EventArgs e)
        {
            Color peru = Color.FromArgb("#CD853F");
            this.BackgroundColor = peru;
            ColorLabel.Text = "Aktualny kolor: Peru (#CD853F)";
        }

    }
}
