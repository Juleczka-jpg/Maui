namespace _02_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowButtonClicked(object? sender, EventArgs e)
        {
            string miasto = MiastoEntry.Text;
            ResultLabel.Text = $"Pozdrowienia z miasta: {miasto}";
        }
    }
}
