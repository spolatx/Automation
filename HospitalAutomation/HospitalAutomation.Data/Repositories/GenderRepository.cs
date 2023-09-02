using HospitalAutomation.Data.Helpers;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        public List<Cinsiyet> GetGenders()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Cinsiyet> genders = new List<Cinsiyet>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Cinsiyetler";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var gender = new Cinsiyet();
                gender.Id = reader.GetInt32(0);
                gender.Aciklama = reader.GetString(1);

                genders.Add(gender);
            }
            reader.Close();
            connection.Close();


            return genders;
        }
    }
}
