using System;
using System.Collections.Generic;

namespace CloudApiService
{
    
    public class Tzinfo    {
        
        public string name { get; set; } 
        public string abbr { get; set; } 
        public int offset { get; set; } 
        public bool dst { get; set; } 
    }

    
}
