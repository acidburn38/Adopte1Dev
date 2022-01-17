﻿using Adopte1Dev.DAL.Entities;
using Adopte1Dev.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adopte1Dev.DAL.Repositories
{
    public class DeveloperService : ServiceBase, IDeveloperRepository<Developer>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Developer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Developer> Get()
        {
            throw new NotImplementedException();
        }

        public int Insert(Developer entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_Developer_Insert";
                    //Parameters...
                    SqlParameter p_DevName = new SqlParameter("DevName", entity.DevName);
                    command.Parameters.Add(p_DevName);
                    SqlParameter p_DevFirstName = new SqlParameter("DevFirstName", entity.DevFirstName);
                    command.Parameters.Add(p_DevFirstName);
                    SqlParameter p_DevBirthDate = new SqlParameter("DevBirthDate", entity.DevBirthDate);
                    command.Parameters.Add(p_DevBirthDate);
                    SqlParameter p_DevPicture = new SqlParameter("DevPicture", entity.DevPicture);
                    command.Parameters.Add(p_DevPicture);
                    SqlParameter p_DevHourCost = new SqlParameter("DevHourCost", entity.DevHourCost);
                    command.Parameters.Add(p_DevHourCost);
                    SqlParameter p_DevDayCost = new SqlParameter("DevDayCost", entity.DevDayCost);
                    command.Parameters.Add(p_DevDayCost);
                    SqlParameter p_DevMonthCost = new SqlParameter("DevMonthCost", entity.DevMonthCost);
                    command.Parameters.Add(p_DevMonthCost);
                    SqlParameter p_DevMail = new SqlParameter("DevMonthCost", entity.DevMail);
                    command.Parameters.Add(p_DevMail);
                    SqlParameter p_DevCategPrincipal = new SqlParameter("DevCategPrincipal", entity.DevCategPrincipal);
                    command.Parameters.Add(p_DevCategPrincipal);
                    connection.Open();
                    //Choose Execution method
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Developer entity)
        {
            throw new NotImplementedException();
        }
    }
}