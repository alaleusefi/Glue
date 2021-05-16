using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Logic.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace Glue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryRepository Repo;
        private readonly IDeliveryLogic Logic;
        private readonly ILogger<DeliveryController> Logger;

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryRepository repo, IDeliveryLogic logic)
        {
            Logger = logger;
            Repo = repo;
            Logic = logic;
        }

        [HttpPost("Create")]
        public Delivery Create([FromBody]Delivery delivery)
        {
            Repo.Create(delivery);
            return delivery;
        }

        [HttpGet("Get/{id}")]
        public Delivery Get(string id)
        {
            return Repo.Get(new Guid(id));
        }

        [HttpPost("Delete/{id}")]
        public void Delete(string id)
        {
            Repo.Delete(new Guid(id));
        }

        [HttpPost("Approve/{id}")]
        public Delivery Approve(string id)
        {
            return Logic.Approve(new Guid(id));
        }

        [HttpPost("Complete/{id}")]
        public Delivery Complete(string id)
        {
            // return Logic.Complete(new Guid(id));
            throw new NotImplementedException();
        }

        [HttpPost("Cancel/{id}")]
        public Delivery Cancel(string id)
        {
            // return Logic.Cancel(new Guid(id));
            throw new NotImplementedException();
        }
    }
}
