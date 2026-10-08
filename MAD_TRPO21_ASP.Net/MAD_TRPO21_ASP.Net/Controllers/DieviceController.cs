using MAD_TRPO21_ASP.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAD_TRPO21_ASP.Net.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DieviceController :ControllerBase
    {

        WebApiDatabaseContext db;

        [HttpGet]
        public IActionResult GetAll ()
        {
            var _db = db.Devices;


            return Ok(_db.ToList());
        }


        [HttpGet("{id:int}")]
        public IActionResult Get (int id)
        {
            var device = db.Devices
                .Select(x => x.Id);

            if (device == null)
                return NotFound();
            return Ok(device);
        }



        [HttpPost]
        public IActionResult Create (Device device)
        {
            if (device == null)
                return BadRequest();
            db.Devices.Add(device);
            db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete (int id)
        {

            Device? d = (Device) db.Devices.Select(x => x.Id == id);
            if(d==null)
                return NotFound();
            db.Devices
                .Remove(d);
            db.SaveChanges();
            return Ok();
        }

        [HttpPatch]
        public IActionResult Edit(int id)
        {

            return Ok();
        }
    }
}
