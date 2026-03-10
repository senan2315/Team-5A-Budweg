using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg.Models
{
    public class SparePart
    {
        public int SparePartId { get; set; }
        private string SparepartType { get; set; }
        private int SparePartQuantity { get; set; }

        public SparePart(int id)
        {
            SparePartId = id;
        }
    }

}
