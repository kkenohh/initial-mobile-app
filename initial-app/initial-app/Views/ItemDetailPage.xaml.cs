using initial_app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace initial_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}