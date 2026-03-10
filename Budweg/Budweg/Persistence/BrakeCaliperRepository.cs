using Budweg.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace Budweg.Persistence
{
    public class BrakeCaliperRepository
    {
        private readonly string ConnectionString;

        public BrakeCaliperRepository()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ConnectionString = config.GetConnectionString("MyDBConnection");
        }

        public void CreateBrakeCaliper(BrakeCaliper brakeCaliperToBeCreated)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = "INSERT INTO BRAKECALIPER (CaliperType, CaliperStatus, Barcode, CaliperNumber, OrderNumber, Note) " +
                             "VALUES (@CaliperType, @CaliperStatus, @Barcode, @CaliperNumber, @OrderNumber, @Note)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CaliperType", brakeCaliperToBeCreated.CaliperType);
                    cmd.Parameters.AddWithValue("@CaliperStatus", brakeCaliperToBeCreated.CaliperStatus.ToString());
                    cmd.Parameters.AddWithValue("@Barcode", brakeCaliperToBeCreated.Barcode);
                    cmd.Parameters.AddWithValue("@CaliperNumber", brakeCaliperToBeCreated.CaliperNumber);
                    cmd.Parameters.AddWithValue("@OrderNumber", brakeCaliperToBeCreated.OrderNumber);
                    cmd.Parameters.AddWithValue("@Note", brakeCaliperToBeCreated.Note ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public BrakeCaliper FindByBarcode(string barcode)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = "SELECT * FROM BRAKECALIPER WHERE Barcode = @Barcode";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            BrakeCaliper c = new BrakeCaliper(Convert.ToInt32(reader["CaliperId"]))
                            {
                                CaliperType = reader["CaliperType"].ToString(),
                                Barcode = reader["Barcode"].ToString(),
                                CaliperNumber = reader["CaliperNumber"].ToString(),
                                OrderNumber = reader["OrderNumber"].ToString(),
                                Note = reader["Note"].ToString()
                            };
                            
                            c.CaliperStatus = Enum.Parse<ProcessingStatus>(reader["CaliperStatus"].ToString());
                            return c;
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateStatus(string caliperNumber, ProcessingStatus status)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = "UPDATE BRAKECALIPER SET CaliperStatus = @Status WHERE CaliperNumber = @CaliperNumber";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status.ToString());
                    cmd.Parameters.AddWithValue("@CaliperNumber", caliperNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}