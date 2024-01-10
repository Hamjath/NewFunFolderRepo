using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Fw.Models.mapper
{
    public class TraceMapper
    {
        public static Trace MapToUser(SqlDataReader reader)
        {

            Trace trace = new Trace();
            trace.TracerId = reader["TracerId"] as string;
            trace.ProjectId = reader["ProjectId"] as string;
            trace.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
            //trace.Day = reader["Day"] as string;
            trace.HoursWorked = reader.GetInt32(reader.GetOrdinal("HoursWorked"));
            trace.UserId = reader["UserId"] as string;
            trace.WorkedDescription = reader["WorkedDescription"] as string;
            trace.IsActive = reader.GetInt32(reader.GetOrdinal("IsActive"));
            return trace;
        }
    }
}
