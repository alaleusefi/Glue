using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;
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
        public Delivery Create([FromBody]Delivery delivery)
        {
            Repo.Create(delivery);
            return delivery;
        }
    }
}
