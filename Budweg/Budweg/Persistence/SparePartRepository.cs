using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class SparePartRepository
    {
        private readonly string connectionString;
        private List<SparePart> spareParts = new List<SparePart>();

        public SparePartRepository(string connection)
        {
            connectionString = connection;
        }

        public void CreateSparePart() 
        { 

        }
        public List<SparePart> FindByStation(string stationName)
        {
            return spareParts;
        }

        public void AddSparePart(string sparePartType, int sparePartQuantity, string stationName)
        {

        }
        public void UpdateQuantity(string sparePartType, int sparePartQuantity)
        {

        }

    }
}
