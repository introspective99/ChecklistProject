using ChecklistProject.Interfaces;
using ChecklistProject.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ChecklistProject.ProjectLogic
{
    public class SQLLogic : ISQLLogic
    {
        public void SendMasterListToSQLServer()
        {
            var connectionString = @"Data Source=CIM-STF-00417\CMSQLSERVER;Initial Catalog = ChecklistProjectDB; Integrated Security = True";
            var sqlConnection  = new SqlConnection(connectionString);

            string sqlString = "INSERT INTO ChecklistTasksTable([Task Description],[Due Date],[Completion Status]) VALUES(@param1,@param2,@param3)";
            sqlConnection.Open();
            string sqlDeleteString = "DELETE FROM ChecklistTasksTable";
            using (SqlCommand cmd = new SqlCommand(sqlDeleteString, sqlConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            foreach (TaskObject task in TaskObjectLogic.masterTaskList)
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
            sqlConnection.Close();
            Thread.Sleep(500);
        }
        public void ReadMasterListFromSQL()
        {
            var connectionString = @"Data Source=CIM-STF-00417\CMSQLSERVER;Initial Catalog = ChecklistProjectDB; Integrated Security = True";
            var sqlConnection = new SqlConnection(connectionString);
             
            using (sqlConnection)
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ChecklistTasksTable", sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                TaskObject openTask = new TaskObject()
                                {
                                    Description = reader["Task Description"].ToString(),
                                    DueDate = (DateTime)reader["Due Date"],
                                    CompletionStatus = (bool)reader["Completion Status"],
                                };
                                TaskObjectLogic.masterTaskList.Add(openTask);
                            }
                        }
                    }
                }
            }
            sqlConnection.Close();
        }
    }
}


