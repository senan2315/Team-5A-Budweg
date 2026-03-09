using Budweg.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Text;


namespace Budweg.Persistence
{
    public class BrakeCaliperRepository
    {
        private readonly string ConnectionString;
        private List<BrakeCaliper> brakeCalipers = new List<BrakeCaliper>();
        public BrakeCaliperRepository()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            brakeCalipers = new List<BrakeCaliper>();

            ConnectionString = config.GetConnectionString("MyDBConnection");
        }

        public void CreateBrakeCaliper(BrakeCaliper brakeCaliperToBeCreated) 
        { 
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("" +
                    "INSERT INTO BRAKECALIPER (CaliperType, CaliperStatus, Barcode, CaliperNumber, OrderNumber, Note) " +
                    "VALUES (@CaliperType, @CaliperStatus, @Barcode, @CaliperNumber, @OrderNumber, @Note)", con))
                {
                    cmd.Parameters.AddWithValue("@CaliperType", brakeCaliperToBeCreated.CaliperType);
                    cmd.Parameters.AddWithValue("@CaliperStatus", brakeCaliperToBeCreated.CaliperStatus.ToString());
                    cmd.Parameters.AddWithValue("@Barcode", brakeCaliperToBeCreated.Barcode);
                    cmd.Parameters.AddWithValue("@CaliperNumber", brakeCaliperToBeCreated.CaliperNumber);
                    cmd.Parameters.AddWithValue("@OrderNumber", brakeCaliperToBeCreated.OrderNumber);
                    cmd.Parameters.AddWithValue("@Note", brakeCaliperToBeCreated.Note);
                    cmd.ExecuteNonQuery();
                }
            }
        }
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
