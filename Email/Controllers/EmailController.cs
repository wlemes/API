using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Email.Data;
using Email.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Email.Controllers
{

    [Route("api/[controller]")]
    //[Route("api/[controller]/[action]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly AgendiaContexto _agendiaContexto;

        public EmailController(AgendiaContexto agendiaContexto)
        {
            _agendiaContexto = agendiaContexto;
        }

        [HttpGet("email")]
        public ActionResult Post(string email)
        {
            if (!_agendiaContexto.Usuario.Any(p => p.Email.Equals(email)))
                return BadRequest("Error?");

            return Ok(_agendiaContexto.Usuario.Where(p => p.Email.Equals(email)).FirstOrDefault().Senha);
        }

    }
}