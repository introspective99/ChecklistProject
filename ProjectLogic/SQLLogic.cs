using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecklistProject.ProjectLogic
{
    public static class SQLLogic
    {
        public static string connectionString = @"Data Source=CIM-STF-00417\CMSQLSERVER;Initial Catalog = ChecklistProjectDB; Integrated Security = True";

        public static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public static void SendToSQLServer()
        {
            //sqlConnection.Open();
            string sqlString = "INSERT INTO ChecklistTasksDB([Task Description],[Due Date],[Completion Status]) VALUES(@param1,@param2,@param3)";
            foreach (OpenTasks task in Logic.taskList)
            {
                using (SqlCommand cmd = new SqlCommand(sqlString, sqlConnection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.Text).Value = task.Description;
                    cmd.Parameters.Add("@param2", SqlDbType.DateTime).Value = task.DueDate;
                    cmd.Parameters.Add("@param3", SqlDbType.Bit).Value = task.CompletionStatus;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void ClearSQLTable()
        {
            sqlConnection.Open();
            string sqlString = "DELETE FROM ChecklistTasksDB";
            using (SqlCommand cmd = new SqlCommand(sqlString, sqlConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public static void ReadFromSQL()
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ChecklisttasksDB", sqlConnection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader != null)
                        {
                            while (reader.Read())
                            {
                                OpenTasks openTask = new OpenTasks()
                                {
                                    Description = reader["Task Description"].ToString(),
                                    DueDate = (DateTime)reader["Due Date"],
                                    CompletionStatus = (bool)reader["Completion Status"],
                                };
                                Logic.taskList.Add(openTask);
                            }
                        }
                    }
                }
            }
        }
    }
}

