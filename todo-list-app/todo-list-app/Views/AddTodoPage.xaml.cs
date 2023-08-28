using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_list_app.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todo_list_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTodoPage : ContentPage
    {
        public AddTodoPage()
        {
            InitializeComponent();
            BindingContext = new AddTodoView();
        }
    }
}