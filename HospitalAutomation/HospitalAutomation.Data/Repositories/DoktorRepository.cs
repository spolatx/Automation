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
    public class DoktorRepository : IDoktorRepository
    {
        public List<Personeller> GetListDoktor()
        {
            List<Personeller>doktorlar = new List<Personeller>();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection=connection;
            command.CommandText = "select * from Personeller where MeslekKodu='1'";
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var doktor = new Personeller();
                doktor.Id = reader.GetInt32(0);
                //doktor.SicilNo= reader.GetInt32(1);
                doktor.Ad = reader.GetString(2);
                //doktor.Soyad=reader.GetString(3);
                //doktor.DiplomaNo = reader.GetInt32(4);
                //doktor.Adres=reader.GetString(5);
                //doktor.CinsiyetId = reader.GetInt32(6);
                //doktor.TelNo= reader.GetInt32(7);
                //doktor.TelNo2=reader.GetInt32(8);
                //doktor.EMail=reader.GetString(9);
                //doktor.DogumTarihi = reader.GetString(10);
                //doktor.DogumYeri= reader.GetString(11);
                //doktor.UnvanId = reader.GetInt32(12);
                //doktor.KlinikId=reader.GetInt32(13);
                //doktor.HastaneId=reader.GetInt32(14);
                doktor.MeslekKodu = reader.GetString(15);
                doktorlar.Add(doktor);
            }
            reader.Close();

            return doktorlar;
        }
    }
}
