namespace _03_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSendClicked(object? sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string numerTelefonu = PhoneNumberEntry.Text;

            DisplayAlert("Zapisano", $"Dane: {email} {numerTelefonu}", "OK");
        }

        private void OnDeleteClicked(object? sender, EventArgs e)
        {
            EmailEntry.Text = string.Empty;
            PhoneNumberEntry.Text = string.Empty;
        }
    }
}
