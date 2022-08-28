using System.Collections.Generic;

namespace onlineShopping.ViewModels
{
    public class Pagination<T>
    {
        public int PageCount { get; set; }

        public int CurrentCount { get; set; }

        public List<T> Items { get; set; }

        public string imgRoot { get; set; }

    }
}
