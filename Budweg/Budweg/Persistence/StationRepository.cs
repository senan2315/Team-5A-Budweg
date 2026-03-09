using Budweg.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class StationRepository
    {
        private readonly string connectionString;
        private List<Station> stations = new List<Station>();
        public StationRepository(string connection)
        {
            connectionString = connection;
        }
        public void CreateStation()
        {
        }
        public Station FindByName(string stationName)
        {
            return stations.FirstOrDefault(s => s.StationId.ToString() == stationName);
        }

        public List<Station> FindAllStations()
        {
            return stations;
        }

        public Station GetNextStation(string stationName)
        {
            return null;
        }
    }
}
