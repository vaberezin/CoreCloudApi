using System;
using System.Collections.Generic;

namespace CloudApiService
{
    public class Parts    {
        public Night night { get; set; } 
        public Morning morning { get; set; } 
        public Day day { get; set; } 
        public Evening evening { get; set; } 
        public DayShort day_short { get; set; } 
        public NightShort night_short { get; set; } 
    }
}
