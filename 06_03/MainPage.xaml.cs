namespace _06_03
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPlusClicked(object? sender, EventArgs e)
        {
            count++;
            ValueLabel.Text = count.ToString();
        }

        private void OnMinusClicked(object? sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                ValueLabel.Text = count.ToString();
            }
            else ValueLabel.Text = count.ToString();
        }

        private void OnResetClicked(object? sender, EventArgs e)
        {
            count = 0;
            ValueLabel.Text = count.ToString();
        }
    }
}
