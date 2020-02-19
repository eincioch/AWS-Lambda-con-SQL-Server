using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS.EVSoft.Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless.EVSoft.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        public IList<Persona> Personas { get { return PersonaData.Personas; } }
        public IActionResult GetPersona() {

            return BadRequest(Personas);

        }
    }
}