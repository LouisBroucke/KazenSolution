using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using KazenService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KazenService.Controllers
{
    [Route("kazen")]
    [ApiController]
    public class KazenController : ControllerBase
    {
        private readonly IKazenRepository repository;
        public KazenController(IKazenRepository repository)
        {
            this.repository = repository;
        }
    }
}