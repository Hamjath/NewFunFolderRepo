using System.Data.SqlClient;
//using System;
//using System.Data.SqlClient;


namespace Fw.Models.mapper
{
    public static class ProjectMapper
    {
        public static Project MapToUser(SqlDataReader reader)
        {

            Project project = new Project();
            project.ProjectId = reader["ProjectId"] as string;
            project.ProjectName = reader["ProjectName"] as string;
            project.ProjectDesc = reader["ProjectDesc"] as string;
            project.HoursAllocated = reader.GetInt32(reader.GetOrdinal("HoursAllocated"));
            project.IsActive = reader.GetInt32(reader.GetOrdinal("IsActive"));
            project.UserId = reader["UserId"] as string;

            return project;
        }
    }
}

