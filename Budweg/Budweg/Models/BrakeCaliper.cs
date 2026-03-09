using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class BrakeCaliper
    {
        public int CaliperId { get; set; }
        public string CaliperType { get; set; }
        public ProcessingStatus CaliperStatus { get; set; }
        public string Barcode { get; set; }
        public string CaliperNumber { get; set; }
        public string OrderNumber { get; set; }
        public string Note { get; set; }

        public BrakeCaliper(int id) 
        { 
            CaliperId = id; 
        }
    }
}
