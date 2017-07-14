using System;
using System.Collections.Generic;

namespace DynaHealth.iOS.Models
{
    public class Search
    {
        public Search()
        {
            Results = new List<Item>();
        }

        public int Count { get; set; }
        public List<Item> Results { get; set; }
	}


}
