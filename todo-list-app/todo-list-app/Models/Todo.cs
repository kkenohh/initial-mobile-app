using System;

namespace todo_list_app.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }

        
        // Takes another Todo and compares the priority
        // Returns - 0 for equal priority
        //           a positive int if this Todo is higher priority
        //           a negative int if this Todo is lower priority
        /*public int HigherPriority(Todo other)
        {
            return this.Priority - other.Priority;
        }*/
    }
}