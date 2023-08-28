using System;
using System.Collections.Generic;
using System.Text;

namespace todo_list_app.ViewModels
{
    public class AddTodoView : BaseViewModel
    {
        private string description = string.Empty;
        private string priority = string.Empty;
        
        public string Description { get { return description; } set {  description = value; } }

        public string Priority { get { return priority; } set { priority = value; } }
    }
}
