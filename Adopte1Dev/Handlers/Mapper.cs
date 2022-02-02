using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adopte1Dev.BLL.Entities;
using Adopte1Dev.ASP.Models;

namespace Adopte1Dev.ASP.Handlers
{
    public static class Mapper
    {
        public static DeveloperListItem ToListItem(this Developer entity)
        {
            if (entity == null) return null;
            return new DeveloperListItem
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevCategPrincipal = entity.DevCategPrincipal,
            };
        }

        public static DeveloperDetails ToDetails(this Developer entity)
        {
            if (entity == null) return null;
            return new DeveloperDetails
            {
                IdDev = entity.IdDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.DevBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal,
            };
        }

        public static CategoriesDetails ToDetails(this Categories entity)
        {
            if (entity == null) return null;
            return new CategoriesDetails
            {
                IdCategory = entity.IdCategory,
                CategLabel = entity.CategLabel,
            };
        }

    }
}