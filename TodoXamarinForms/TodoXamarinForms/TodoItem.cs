using System;
using System.Collections.Generic;
using System.Text;

namespace TodoXamarinForms
{
    public class TodoItem : BaseFodyObservable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}

