using DOTNET.TEMPLATE.COMMON.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET.TEMPLATE.WEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        public ActionResult Create(UserResource userResource)
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult Edit(UserResource userResource)
        {
            return Ok();
        }
        
        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
        [HttpGet("id")]
        public ActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok();
        }


    }
}
