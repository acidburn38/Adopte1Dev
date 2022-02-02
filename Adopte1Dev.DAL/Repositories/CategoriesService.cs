using Adopte1Dev.DAL.Entities;
using Adopte1Dev.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adopte1Dev.DAL.Repositories
{
    public class CategoriesService : ServiceBase, ICategoriesRepository<Categories>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categories Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT [idCategory],[CategLabel]
                    FROM [dbo].[Categories]
                    WHERE [idCategory] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToCategories(reader);
                    return null;

                }
            }
        }

        
        public IEnumerable<Categories> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT [idCategory],[CategLabel]
                    FROM [dbo].[Categories]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToCategories(reader);
                }
            }
        }

        public int Insert(Categories entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Categories entity)
        {
            throw new NotImplementedException();
        }
    }
}

