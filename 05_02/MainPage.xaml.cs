namespace _05_02
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
