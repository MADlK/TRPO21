using MAD_TRPO21_ASP.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAD_TRPO21_ASP.Net.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DieviceController :ControllerBase
    {

        WebApiDatabaseContext db = new();

        [HttpGet]
        public IActionResult GetAll ([FromQuery] string? Manufacturer, [FromQuery]decimal? minPrice)
        {
            
            List<Device> list = db.Devices.ToList();
            if(!String.IsNullOrEmpty(Manufacturer))
            {
                list = list.Where(b => b.Manufacturer == Manufacturer).ToList();
            }
            if(minPrice.HasValue)
            {
                list = list.Where(b => b.Price >= minPrice).ToList();
            }

            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
            
        }


        [HttpGet("{id:int}")]
        public IActionResult Get (int id)
        {
            var device = db.Devices
                .FirstOrDefault(x => x.Id == id);

            if (device == null || device is not Device)
                return NotFound();
            else
                return Ok(device);
        }



        [HttpPost]
        public IActionResult Create (Device device)
        {
            if (device == null)
                return BadRequest();
            db.Devices.Add(device);
            db.SaveChanges();

            return Created();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete (int id)
        {

            var d =  db.Devices.FirstOrDefault(x => x.Id == id);
            if(d==null || d is not Device)
                return NotFound();
            db.Devices
                .Remove((Device)d);
            db.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public IActionResult Edit (int id,[FromBody] Device pdevice)
        {
            var d = db.Devices.FirstOrDefault(x => x.Id == id);
            if (d == null || d is not Device)
                return NotFound();

            if (!String.IsNullOrEmpty(pdevice.Manufacturer))
                d.Manufacturer = pdevice.Manufacturer;
            if (!String.IsNullOrEmpty(pdevice.Name))
                d.Name = pdevice.Name;
            if (pdevice.Price != null )
                d.Price = pdevice.Price;
            if (pdevice.Quantity != null)
                d.Quantity = pdevice.Quantity;
            if(pdevice.IsActive != null)
                d.IsActive = pdevice.IsActive;
            db.SaveChanges();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult AllEdit(int id, [FromBody] Device pdevice)
        {
            var d =db.Devices.FirstOrDefault(y => y.Id == id);
            if (d == null || d is not Device)
                return NotFound();
            d = pdevice;
            d.Id = id;
            db.SaveChanges();
            return Ok();
        }
    }
}
