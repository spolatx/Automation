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
    public class KanGrubuRepository:IKanGrubuRepository
    {
        /// <summary>
        /// Kan Gruplarini sqlden çeker ve liste olarak geri döner.
        /// </summary>
        /// <returns></returns>
        public List<KanGruplari> GetKanGruplari()
        {
            var connection = new DbConnectionHelper().Connection;

            List<KanGruplari> kanGruplarıList = new List<KanGruplari>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from KanGrubu";
            command.Connection = connection;

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var kanGruplari = new KanGruplari();
                kanGruplari.Id = reader.GetInt32(0);
                kanGruplari.KanGrubuAdi = reader.GetString(1);
                kanGruplarıList.Add(kanGruplari);
            }
            connection.Close();
            reader.Close();
            return kanGruplarıList;
        }
    }
}
