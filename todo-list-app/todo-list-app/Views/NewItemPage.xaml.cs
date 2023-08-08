using System;
using System.Collections.Generic;
using System.ComponentModel;
using todo_list_app.Models;
using todo_list_app.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todo_list_app.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}