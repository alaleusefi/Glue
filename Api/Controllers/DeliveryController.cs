using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;
using API.Request;
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
        private readonly ILogger<DeliveryController> Logger;

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryRepository repo)
        {
            Logger = logger;
            Repo = repo;
        }

        [HttpPost("Create")]
        public Delivery Create([FromBody]CreateDeliveryRequest request)
        {
            var delivery = new Delivery { Id = 1 };
            Repo.Create(delivery);
            return delivery;
        }
    }
}
