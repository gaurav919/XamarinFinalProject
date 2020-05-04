using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeApp.ViewModel
{
    public class BugListViewModel
    {
        public string Name { get; set; }
        public DateTime spottedDate { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }

        public string insectMatch { get; set; }
        public string isPest { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }


    }
}
