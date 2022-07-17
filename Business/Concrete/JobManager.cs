using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobManager : IJobDal
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void Add(Job entity)
        {
            _jobDal.Add(entity);
        }

        public void Delete(Job entity)
        {
            _jobDal.Delete(entity);
        }
        public void Update(Job entity)
        {
            _jobDal.Update(entity);
        }
        public Job GetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public List<Job> GetList()
        {
            return _jobDal.GetList();
        }

       
    }
}
