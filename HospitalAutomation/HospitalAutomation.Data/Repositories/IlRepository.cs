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
          List<Iller> iller = new List<Iller>();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType=System.Data.CommandType.Text;
            command.Connection= connection;
            command.CommandText = "Select * from iller";
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var il=new Iller();
                il.Id = reader.GetInt32(0);
                il.SehirAdi = reader.GetString(1);
                iller.Add(il);
            }
            reader.Close();
            connection.Close();
            return iller;
        }
    }
}
