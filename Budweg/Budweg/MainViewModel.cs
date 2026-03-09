using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg
{
    public class MainViewModel
    {
        private BrakeCaliperRepository brakeCaliperRepo;
        private StationRepository stationRepo;
        private SparePartRepository sparePartRepo;

        public MainViewModel(
            BrakeCaliperRepository brakeRepo, 
            StationRepository stationRepo, 
            SparePartRepository spareRepo)
        {
            this.brakeCaliperRepo = brakeRepo;
            this.stationRepo = stationRepo;
            this.sparePartRepo = spareRepo;
        }
    }
}
