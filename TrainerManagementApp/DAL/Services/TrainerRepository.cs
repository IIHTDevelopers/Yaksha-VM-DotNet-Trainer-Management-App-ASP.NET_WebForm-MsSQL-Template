using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TrainerManagementApp.DAL.Interfaces;

namespace TrainerManagementApp.DAL.Services
{
    public class TrainerRepository : Interfaces.ITrainerRepository
    {
        private TrainerDbContext _context;

        public TrainerRepository(TrainerDbContext context)
        {
            _context = context;
        }

        public Model.TrainerModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}