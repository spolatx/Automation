using HospitalAutomation.Data.Helpers;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Repositories
{
    public class HastaRepository : IHastaRepository
    {
        public List<Hastalar> GetHastalar()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Hastalar> hastalarList = new List<Hastalar>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from Hastalar";
            command.Connection = connection;

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var hastalar = new Hastalar();
                hastalar.Id = reader.GetInt32(0);
                hastalar.HastaAd = reader.GetString(1);
                hastalar.HastaSoyad = reader.GetString(2);
                hastalarList.Add(hastalar);
            }
            connection.Close();
            reader.Close();
            return hastalarList;
        }
    }
}
