using TimeManagementApp.DAL.Interrfaces;
using TimeManagementApp.DAL.Services.Repository;
using TimeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TimeManagementApp.DAL.Services
{
    public class TimeService : ITimeService
    {
        private readonly ITimeRepository _repository;

        public TimeService(ITimeRepository repository)
        {
            _repository = repository;
        }

        public Task<Time> CreateTime(Time expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTimeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Time> GetAllTimes()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Time> GetTimeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Time> UpdateTime(Time model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}