namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGradeChanged(object? sender, EventArgs e)
        {
            int ocena = (int)GradeSlider.Value;

            ResultLabel.Text = $"Ocena: {ocena}";
        }
    }
}
