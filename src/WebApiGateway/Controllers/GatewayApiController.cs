using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGateway.Controllers
{
    public class GatewayApiController :ApiController
    {
        [HttpGet]
        public string Get()
        {
        return "我是api网关！我是微服务架构中的唯一入口";
        }
    }
}
