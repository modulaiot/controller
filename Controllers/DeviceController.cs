using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ModulaIot.Controller.Controllers
{
    public static class InformApi
    {
        public class Request
        {
            public string Id { get; set; }
        }
        public class Response
        {
            public string Key { get; set; }
        }
    }

    [ApiController, Route("api/device")]
    public class DeviceController : ControllerBase
    {

        [HttpPost("inform")]
        public InformApi.Response Inform(InformApi.Request data)
        {
            return new InformApi.Response
            {
                Key = "123456789"
            };
        }
    }
}