using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class Station
    {
        public int StationId { get; set; }
        private string StationType { get; set; }
        private string StationName { get; set; }
        public Station(int id)
        {
            StationId = id;
        }
    }
}
