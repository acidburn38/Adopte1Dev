using Adopte1Dev.BLL.Entities;
using Adopte1Dev.BLL.Handlers;
using Adopte1Dev.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1Dev.BLL.Services
{
    public class CategoriesServices : ICategoriesRepository<Categories>
    {
        private readonly ICategoriesRepository<DAL.Entities.Categories> _categoriesRepository;

        public CategoriesServices(ICategoriesRepository<DAL.Entities.Categories> repository)
        {
            _categoriesRepository = repository;
        }
        public void Delete(int id)
        {
            _categoriesRepository.Delete(id);
        }

        public Categories Get(int id)
        {
            return _categoriesRepository.Get(id).ToBLL();
        }

        public IEnumerable<Categories> Get()
        {
            return _categoriesRepository.Get().Select(categories => categories.ToBLL());
        }

        public int Insert(Categories entity)
        {
            return _categoriesRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Categories entity)
        {
            _categoriesRepository.Update(id, entity.ToDAL());
        }
    }
}
