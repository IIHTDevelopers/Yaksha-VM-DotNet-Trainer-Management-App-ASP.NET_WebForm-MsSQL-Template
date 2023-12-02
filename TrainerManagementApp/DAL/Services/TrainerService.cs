using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TrainerManagementApp.DAL.Interfaces;
using TrainerManagementApp.Model;

namespace TrainerManagementApp.DAL.Services
{
    public class TrainerService : Interfaces.ITrainerService
    {
        private Interfaces.ITrainerRepository _repository;

        public TrainerService(Interfaces.ITrainerRepository repository)
        {
            _repository = repository;
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

        public TrainerModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}