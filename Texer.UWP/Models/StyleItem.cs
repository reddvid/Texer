using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Texer.UWP.Models
{
    class StyleItem
    {
        public StyleItem() { }
        public string StyleType { get; set; }
        public string TextResult { get; set; }
        public DateTimeOffset SavedDate { get; set; }

        public StyleItem(string t, string r)
        {
            StyleType = t;
            TextResult = r;
            SavedDate = DateTime.Now;
        }


    }
}
