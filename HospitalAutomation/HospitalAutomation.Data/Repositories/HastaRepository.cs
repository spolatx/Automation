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
            command.CommandText = "select * from hastalar inner join Cinsiyetler on hastalar.Cinsiyet = Cinsiyetler.Id inner join KanGrubu on hastalar.KanGrubuID = KanGrubu.ID inner join Iller on hastalar.DoğumYeriID = Iller.ID";
            command.Connection = connection;

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var hastalar = new Hastalar();
                hastalar.Id = reader.GetInt32(0);
                hastalar.HastaAd = reader.GetString(1);
                hastalar.HastaSoyad = reader.GetString(2);
                hastalar.TcKimlikNo = reader.GetInt32(8);
                hastalar.DogumTarihi = reader.GetString(9);
                hastalar.Aciklama = reader.GetString(21);
                hastalar.KanGrubu = reader.GetString(23);
                hastalar.DogumYeri = reader.GetString(25);
                hastalarList.Add(hastalar);
            }
            connection.Close();
            reader.Close();
            return hastalarList;
        }
    }
}
