using System;
using System.Data.SqlClient;
using Fw.Models;

namespace Fw.Models.mapper
{
	public static class UserMapper
	{
		public static User MapToUser(SqlDataReader reader)
		{

            User user = new User();
            user.UserId = reader["UserId"] as string;
            user.UserName = reader["UserName"] as string;
			user.PassWord = reader["PassWord"] as string;
			user.IsActive = reader.GetInt32(reader.GetOrdinal("IsActive"));

			return user;
		}
	}
}