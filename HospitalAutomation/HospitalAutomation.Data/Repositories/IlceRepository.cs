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
    public  class IlceRepository : IIlceRepository
    {
       public List<Ilceler> GetIlceler()
        {
            List<Ilceler> ilcelerList = new List<Ilceler> ();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType=System.Data.CommandType.Text;
            command.Connection = connection;
            connection.Open();
            command.CommandText = "select * from iller inner join ilceler on iller.Id=ilceler.sehirid ";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var ilceler = new Ilceler();
                ilceler.Id = reader.GetInt32(2);
                ilceler.IlceAdi=reader.GetString(3);
                ilceler.SehirId = reader.GetInt32(4);
                ilcelerList.Add(ilceler);
            }
            reader.Close();
            connection.Close();
            return ilcelerList;
        }

     


    }
}
