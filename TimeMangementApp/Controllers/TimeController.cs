using TimeManagement.Models;
using TimeManagementApp.DAL.Interrfaces;
using TimeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TimeManagementApp.Controllers
{
    public class TimeController : ApiController
    {
        private readonly ITimeService _service;
        public TimeController(ITimeService service)
        {
            _service = service;
        }
        public TimeController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Time/CreateTime")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateTime([FromBody] Time model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Time/UpdateTime")]
        public async Task<IHttpActionResult> UpdateTime([FromBody] Time model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Time/DeleteTime")]
        public async Task<IHttpActionResult> DeleteTime(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Time/GetTimeById")]
        public async Task<IHttpActionResult> GetTimeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Time/GetAllTimes")]
        public async Task<IEnumerable<Time>> GetAllTimes()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
