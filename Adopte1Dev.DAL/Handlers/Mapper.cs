using System;

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
                DevPicture = (string)record[nameof(Developer.DevPicture)],
                DevHousCost = (int)record[nameof(Developer.DevHousCost)],
                DevDayCost = (int)record[nameof(Developer.DevDayCost)],
                DevMonthCost = (int)record[nameof(Developer.DevMonthCost)],
                DevMail = (string)record[nameof(Developer.DevMail)],
                DevCategPrincipal = (string)record[nameof(Developer.DevCategPrincipal)],


            };
        }
    }
}
