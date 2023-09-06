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
    public class IlRepository : IIlRepository
    {
        public List<Iller> GetIllers()
        {
            List<Iller> ilList = new List<Iller>();

            var connection = new DbConnectionHelper().Connection;

            SqlCommand command = new SqlCommand();

            command.CommandType=System.Data.CommandType.Text;
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select * from iller";

            var reader =command.ExecuteReader();
            while (reader.Read())
            {
                var iller = new Iller();
                iller.Id = reader.GetInt32(0);
                iller.SehirAdi=reader.GetString(1);
                ilList.Add(iller);
            }
            reader.Close();
            connection.Close();
            return ilList;
        }
    }
}
