using System.Collections.ObjectModel;

namespace _09_02
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> listaZakupow = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnAddClicked(object? sender, EventArgs e)
        {
            string nowe = ShoppingEntry.Text;

            if (string.IsNullOrWhiteSpace(nowe))
            {
                return;
            }

            listaZakupow.Add(nowe);
            ShoppingEntry.Text = "";
        }
    }
}
