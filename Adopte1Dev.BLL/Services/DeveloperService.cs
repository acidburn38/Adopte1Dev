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
    public class DeveloperService : IDeveloperRepository<Developer>
    {
        private readonly IDeveloperRepository<DAL.Entities.Developer> _developerRepository;

        public DeveloperService(IDeveloperRepository<DAL.Entities.Developer> repository)
        {
            _developerRepository = repository;
        }
        public void Delete(int id)
        {
            _developerRepository.Delete(id);
        }

        public Developer Get(int id)
        {
            return _developerRepository.Get(id).ToBLL();
        }

        public IEnumerable<Developer> Get()
        {
            return _developerRepository.Get().Select(developer => developer.ToBLL());
        }

        public int Insert(Developer entity)
        {
            return _developerRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Developer entity)
        {
            _developerRepository.Update(id, entity.ToDAL());
        }
    }
}
