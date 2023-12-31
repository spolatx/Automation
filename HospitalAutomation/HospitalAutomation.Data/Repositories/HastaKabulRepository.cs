﻿using HospitalAutomation.Data.Helpers;
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
    public class HastaKabulRepository : IHastaKabulListRepository
    {
        public void GetHastalar(HastaKabul hastaKabul)
        {
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into HastaKabul values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)";
            command.Parameters.AddWithValue("@p1", hastaKabul.TcNo);
            command.Parameters.AddWithValue("@p2", hastaKabul.Ad);
            command.Parameters.AddWithValue("@p3", hastaKabul.Soyad);
            command.Parameters.AddWithValue("@p4", hastaKabul.CinsiyetId);
            command.Parameters.AddWithValue("@p5", hastaKabul.KanGrubuId);
            command.Parameters.AddWithValue("@p6", hastaKabul.DogumYeriId);
            command.Parameters.AddWithValue("@p7", hastaKabul.DogumTarihi);
            command.Parameters.AddWithValue("@p8", hastaKabul.CepTel);
            command.Parameters.AddWithValue("@p9", hastaKabul.Istel);
            command.Parameters.AddWithValue("@p10", hastaKabul.IlId);
            command.Parameters.AddWithValue("@p11", hastaKabul.IlceId);
            command.Parameters.AddWithValue("@p12", hastaKabul.PoliklinikId);
            command.Parameters.AddWithValue("@p13", hastaKabul.DoktorId);
            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();

        }
        public List<HastaKabul> HastaSorgula(string tcno)
        {
            List<HastaKabul> hastaKabulList = new List<HastaKabul>();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from HastaKabul where TcNo='" + tcno + "'";
            //command.Parameters.AddWithValue("@p1", tcno);
            command.Connection = connection;
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var hastaKabul = new HastaKabul();
                hastaKabul.TcNo = reader.GetString(1);
                hastaKabul.Ad = reader.GetString(2);
                hastaKabul.Soyad = reader.GetString(3);
                hastaKabul.CinsiyetId = reader.GetInt32(4);
                hastaKabul.KanGrubuId = reader.GetInt32(5);
                hastaKabul.DogumYeriId = reader.GetInt32(6);
                hastaKabul.DogumTarihi = reader.GetDateTime(7);
                hastaKabul.CepTel = reader.GetString(8);
                hastaKabul.Istel = reader.GetString(9);
                hastaKabul.IlId = reader.GetInt32(10);
                hastaKabul.IlceId = reader.GetInt32(11);
                hastaKabul.PoliklinikId = reader.GetInt32(12);
                hastaKabul.DoktorId = reader.GetInt32(13);
                hastaKabulList.Add(hastaKabul);
            }
            reader.Close();
            connection.Close();
            return hastaKabulList;

        }
    }
}
