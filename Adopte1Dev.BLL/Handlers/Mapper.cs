using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = Adopte1Dev.DAL.Entities;
using B = Adopte1Dev.BLL.Entities;

namespace Adopte1Dev.BLL.Handlers
{
    public static class Mapper
    {
        public static B.Developer ToBLL(this D.Developer entity)
        {
            if (entity == null) return null;
            return new B.Developer
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.DevBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMonthCost = entity.DevMonthCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal,
            };
        }


        public static D.Developer ToDAL(this B.Developer entity)
        {
            if (entity == null) return null;
            return new D.Developer
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.DevBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMonthCost = entity.DevMonthCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal,
            };
        }
    }
}
