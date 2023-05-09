using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories {
    public class ActivityRepository {
        public static Activities GetActivities (int id) {
            
            Activities activities = null;
            string sql = $"SELECT * FROM Activities WHERE Id = {id}";
            
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows) {
                reader.Read();
                activities = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return activities;
        }

           public static List<Activities> GetActivities() {
            List<Activities> activitiess = new List<Activities>();
            string sql = "SELECT * FROM Activities";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()){
                Activities activitie = CreateObject(reader);
                activitiess.Add(activitie);
            }
            reader.Close();
            DB.CloseConnection();

            return activitiess;
        }

        private static Activities CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int maxPoints = int.Parse(reader["MaxPoints"].ToString());
            int minPointsForGrade = int.Parse(reader["MinPointsForGrade"].ToString() );
            int minPointsForSignature = int.Parse(reader["MinPointsForSignature"].ToString()) ;

            var activities = new Activities {
                Id = id,
                Name = name,
                Description = description,
                MaxPoints = maxPoints,
                MinPintsForGrade = minPointsForGrade,
                MinPointsForSignature = minPointsForSignature

            };
            return activities;
        }
    }
}
