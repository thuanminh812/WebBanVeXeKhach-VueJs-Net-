using BTLWebVeXe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTLWebVeXe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinChuyenController : ControllerBase
    {
        public List<ThongTinChuyen> thongTinChuyens = new List<ThongTinChuyen>();
        DatabaseQLyVeXeContext xeContext = new DatabaseQLyVeXeContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(xeContext.ThongTinChuyens.ToList());
        }
        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName(String name)
        {
            var Name = xeContext.ThongTinChuyens.FirstOrDefault(x => x.MaChuyen == name);
            return Ok(Name);
        }
        [HttpPost]
        public IActionResult Create(ThongTinChuyen thongTinChuyen)
        {
            if (thongTinChuyen == null)
            {
                return BadRequest();
            }
            var add = new ThongTinChuyen
            {
                MaChuyen = thongTinChuyen.MaChuyen,
                Tuyen = thongTinChuyen.Tuyen,
                TrangThai = thongTinChuyen.TrangThai
            };
            xeContext.ThongTinChuyens.Add(add);
            xeContext.SaveChanges();
            return Ok(thongTinChuyen);
        }
        [HttpPut]
        [Route("{name}")]
        public IActionResult Update(String name, ThongTinChuyen thongTinChuyen)
        {
            var Name = xeContext.ThongTinChuyens.FirstOrDefault(x => x.MaChuyen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            Name.MaChuyen = thongTinChuyen.MaChuyen;
            Name.Tuyen = thongTinChuyen.Tuyen;
            Name.TrangThai = thongTinChuyen.TrangThai;
            xeContext.ThongTinChuyens.Update(Name);
            xeContext.SaveChanges();
            return Ok(xeContext.ThongTinChuyens.ToList());
        }
        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(String name)
        {
            var Name = xeContext.ThongTinChuyens.FirstOrDefault(x => x.MaChuyen == name);
            if (Name == null)
            {
                return BadRequest();
            }
            xeContext.ThongTinChuyens.Remove(Name);
            xeContext.SaveChanges();
            return Ok();
        }


    }
}
