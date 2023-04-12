using BTLWebVeXe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTLWebVeXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinTuyenController : ControllerBase
    {
        public List<ThongTinTuyen> thongTinTuyens = new List<ThongTinTuyen>();
        DatabaseQLyVeXeContext xeContext = new DatabaseQLyVeXeContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(xeContext.ThongTinTuyens.ToList());
        }
        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName(String name)
        {
            var Name = xeContext.ThongTinTuyens.FirstOrDefault(x => x.Tuyen == name);
            return Ok(Name);
        }
        [HttpPost]
        public IActionResult Create(ThongTinTuyen thongTinTuyen)
        {
            if (thongTinTuyen == null)
            {
                return BadRequest();
            }
            xeContext.ThongTinTuyens.Add(thongTinTuyen);
            xeContext.SaveChanges();
            return Ok(thongTinTuyen);
        }
        [HttpPut]
        [Route("{name}")]
        public IActionResult Update(String name, ThongTinTuyen thongTinTuyen)
        {
            var Name = xeContext.ThongTinTuyens.FirstOrDefault(x => x.Tuyen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            Name.Tuyen = thongTinTuyen.Tuyen;
            Name.MaTuyen = thongTinTuyen.MaTuyen;
            xeContext.ThongTinTuyens.Update(Name);
            xeContext.SaveChanges();
            return Ok(xeContext.ThongTinTuyens.ToList());
        }
        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(String name)
        {
            var Name = xeContext.ThongTinTuyens.FirstOrDefault(x => x.Tuyen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            xeContext.ThongTinTuyens.Remove(Name);
            xeContext.SaveChanges();
            return Ok();
        }


    }
}
