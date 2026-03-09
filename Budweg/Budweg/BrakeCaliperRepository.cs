using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class BrakeCaliperRepository
    {
        private readonly string connectionString;
        private List<BrakeCaliper> brakeCalipers = new List<BrakeCaliper>();
        public BrakeCaliperRepository(string connection)
        {
            connectionString = connection;
        }
        public void CreateBrakeCaliper() { }
        public BrakeCaliper FindByBarcode(string barcode)
        {
            return null;
        }

        public void MovetoNextStation(string caliperNumber)
        {

        }

        public void UpdateStatus(string caliperNumber, ProcessingStatus status)
        {

        }

        public List<BrakeCaliper> ListByStation(string stationName)
        { 
            return brakeCalipers; 
        }
    }
}
