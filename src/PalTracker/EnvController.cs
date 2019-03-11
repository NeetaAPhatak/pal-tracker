using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("env")]
    public class EnvController : ControllerBase
    {
        private readonly CloudFoundryInfo _cloudFoundryEnv;

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryEnv;

        public EnvController(CloudFoundryInfo cloudFoundryEnv)
        {
            _cloudFoundryEnv = cloudFoundryEnv;
        }
    }
}
