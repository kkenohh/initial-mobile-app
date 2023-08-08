using System.ComponentModel;
using todo_list_app.ViewModels;
using Xamarin.Forms;

namespace todo_list_app.Views
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