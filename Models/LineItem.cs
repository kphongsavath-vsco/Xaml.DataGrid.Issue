using System;
using System.Collections.Generic;
using System.Text;

namespace Xaml.DataGrid.Issue.Models
{
    public class LineItem
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }

        public DateTime ModifiedDate => DateTime.Now;
    }
}
