using TimeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TimeManagementApp.DAL.Services.Repository
{
    public class TimeRepository : ITimeRepository
    {
        private readonly DatabaseContext _dbContext;
        public TimeRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Time> CreateTime(Time expense)
        {  //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTimeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Time> GetAllTimes()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Time> GetTimeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Time> UpdateTime(Time model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}