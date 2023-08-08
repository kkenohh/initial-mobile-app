using System;
using System.Collections.Generic;
using todo_list_app.ViewModels;
using todo_list_app.Views;
using Xamarin.Forms;

namespace todo_list_app
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
