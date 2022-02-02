using Adopte1Dev.DAL.Entities;
using System;
using System.Data;

namespace Adopte1Dev.DAL
{
    public class Mapper
    {
        public static Developer ToDeveloper(IDataRecord record)
        {
            if (record is null) return null;
            return new Developer
            {
                IdDev = (int)record[nameof(Developer.IdDev)],
                DevName = (string)record[nameof(Developer.DevName)],
                DevFirstName = (string)record[nameof(Developer.DevFirstName)],
                DevBirthDate = (DateTime)record[nameof(Developer.DevBirthDate)],
                //DevPicture = (string)record[nameof(Developer.DevPicture)],
                DevPicture = (record[nameof(Developer.DevPicture)]==DBNull.Value)?null:(string)record[nameof(Developer.DevPicture)],
                DevHourCost = (double)record[nameof(Developer.DevHourCost)],
                DevDayCost = (double)record[nameof(Developer.DevDayCost)],
                DevMonthCost = (double)record[nameof(Developer.DevMonthCost)],
                DevMail = (string)record[nameof(Developer.DevMail)],
                //DevCategPrincipal = (string)record[nameof(Developer.DevCategPrincipal)],
                DevCategPrincipal = (record[nameof(Developer.DevCategPrincipal)]==DBNull.Value)?null:(string)record[nameof(Developer.DevCategPrincipal)]
            };
        }
    }
}
