using HospitalAutomation.Data.Helpers;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Repositories
{
    public class PoliklinikRepository : IPoliklinikRepository
    {
        public List<Poliklinikler> GetPoliklinikler()
        {
            List<Poliklinikler>polikliniklers = new List<Poliklinikler>();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType=System.Data.CommandType.Text;
            command.Connection=connection;
            connection.Open();
            command.CommandText="select * from Poliklinikler";
            var reader = command.ExecuteReader();
            while (reader.Read()) 
            {
               var poliklinik = new Poliklinikler();
                poliklinik.Id = reader.GetInt32(0);
                poliklinik.PoliklinikAdi=reader.GetString(1);
               // poliklinik.RandevuSure=reader.GetInt32(2);
                poliklinik.HastaneId = reader.GetInt32(3);
                polikliniklers.Add(poliklinik);
            }
            reader.Close();
            connection.Close();
            return polikliniklers;
        }
    }
}
