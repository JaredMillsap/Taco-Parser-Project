using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        
        
            public string Name { get; set; }
            public Point Location { get; set; }

        public TacoBell(string name, double longitude, double latitude)
        {
            Name = name;
            var loc = new Point() { Longitude = longitude, Latitude = latitude };
            Location = loc;
        }



    }



}
